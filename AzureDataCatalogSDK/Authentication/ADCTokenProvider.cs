using AzureDataCatalogSDK.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AzureDataCatalogSDK.Authentication
{
    public interface IAzureDataCatalogTokenProvider
    {
        Task<AuthenticationResult> GetAuthenticationResult();
    }

    public class AzureDataCatalogTokenProvider : IAzureDataCatalogTokenProvider
    {
        private readonly IDataCatalogConfiguration _dataCatalogConfiguration;

        public AzureDataCatalogTokenProvider(IDataCatalogConfiguration dataCatalogConfiguration)
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