using AzureDataCatalogSDK.Configuration;
using LazyCache;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;

namespace AzureDataCatalogSDK.Authentication
{
    public class CachedADCTokenProvider
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
                var authenticationResponse = await Auth0TokenProvider.RequestAuthenticationResponse();
                //Set up the token to be removed from the cache sometime before it actually expires
                var timespanToSubtract = TimeSpan.Parse(Auth0Configuration.AccessTokenCacheDurationSubtraction);
                DateTimeOffset expirationDate = authenticationResponse.accessTokenExpiresAt.Subtract(timespanToSubtract);
                Logger.LogInformation("Auth0 Access Token Cached expires in " + expirationDate);
                entry.SetAbsoluteExpiration(expirationDate);
                return authenticationResponse;
            });

            return cachedAuthenticationResponse;
        }
    }
}