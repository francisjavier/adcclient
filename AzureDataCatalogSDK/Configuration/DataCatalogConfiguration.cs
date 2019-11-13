using Microsoft.Extensions.Configuration;

namespace AzureDataCatalogSDK.Configuration
{
    public interface IDataCatalogConfiguration
    {
        string AuthorityURI { get; }
        string ResourceURI { get; }
        string ClientId { get; }
        string BaseURI { get; }
        string ClientSecret { get; }
        string ADCAccessTokenKey { get; }
        string AccessTokenCacheDurationSubtraction { get; }
    }

    public class DataCatalogConfiguration : IDataCatalogConfiguration
    {
        private const string ConfigurationKey = "DataCatalogConfiguration";

        public string AuthorityURI { get; set; }
        public string ResourceURI { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string BaseURI { get; set; }
        public string ADCAccessTokenKey { get; set; }
        public string AccessTokenCacheDurationSubtraction { get; set; }

        public DataCatalogConfiguration(IConfiguration configuration)
        {
            configuration.Bind(ConfigurationKey, this);
        }
    }
}