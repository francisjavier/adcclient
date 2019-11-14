using AzureDataCatalogSDK.Configuration;
using LazyCache;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;

namespace AzureDataCatalogSDK.Authentication
{
    public interface ICachedADCTokenProvider
    {
        Task<string> GetToken();
    }

    public class CachedADCTokenProvider : ICachedADCTokenProvider
    {
        private readonly IADCTokenProvider _adcTokenProvider;
        private readonly IAppCache _cache;
        private readonly IDataCatalogConfiguration _dataCatalogConfiguration;

        public CachedADCTokenProvider(IADCTokenProvider adcTokenProvider, IAppCache cache, IDataCatalogConfiguration dataCatalogConfiguration)
        {
            _adcTokenProvider = adcTokenProvider;
            _cache = cache;
            _dataCatalogConfiguration = dataCatalogConfiguration;
        }

        public async Task<string> GetToken()
        {
            var cachedAuthenticationResponse = await _cache.GetOrAddAsync(_dataCatalogConfiguration.ADCAccessTokenKey, async entry =>
            {
                var authenticationResult = await _adcTokenProvider.GetAuthenticationResult();
                //Set up the token to be removed from the cache sometime before it actually expires
                var timespanToSubtract = TimeSpan.Parse(_dataCatalogConfiguration.AccessTokenCacheDurationSubtraction);
                var expirationDate = authenticationResult.ExpiresOn.Subtract(timespanToSubtract);
                entry.SetAbsoluteExpiration(expirationDate);
                return authenticationResult.AccessToken;
            });

            return cachedAuthenticationResponse;
        }
    }
}