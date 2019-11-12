using Microsoft.Extensions.Configuration;

namespace AzureDataCatalogSDK.Configuration
{
    public interface IDataCatalogConfiguration
    {
        string AuthorityURI { get; set; }
        string ResourceURI { get; set; }
        string ClientId { get; set; }
        string BaseURI { get; set; }
        string ClientSecret { get; set; }
        string ADCAccessTokenKey { get; set; }
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

        public DataCatalogConfiguration(IConfiguration configuration)
        {
            configuration.Bind(ConfigurationKey, this);
        }
    }
}