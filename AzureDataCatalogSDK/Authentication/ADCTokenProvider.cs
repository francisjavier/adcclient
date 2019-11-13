using AzureDataCatalogSDK.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AzureDataCatalogSDK.Authentication
{
    public interface IADCTokenProvider
    {
        Task<AuthenticationResult> GetAuthenticationResult();
    }

    public class ADCTokenProvider : IADCTokenProvider
    {
        private readonly IDataCatalogConfiguration _dataCatalogConfiguration;

        public ADCTokenProvider(IDataCatalogConfiguration dataCatalogConfiguration)
        {
            _dataCatalogConfiguration = dataCatalogConfiguration;
        }

        public async Task<AuthenticationResult> GetAuthenticationResult()
        {
            var authContext = new AuthenticationContext(_dataCatalogConfiguration.AuthorityURI);
            var authenticationResult = await authContext.AcquireTokenAsync(_dataCatalogConfiguration.ResourceURI,
                new ClientCredential(_dataCatalogConfiguration.ClientId, _dataCatalogConfiguration.ClientSecret));
            return authenticationResult;
        }
    }
}