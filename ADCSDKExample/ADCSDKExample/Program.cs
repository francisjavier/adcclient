

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.DataCatalog.Authentication;
using Microsoft.Azure.DataCatalog.Rest;
using Microsoft.Azure.DataCatalog.Rest.Models;
using Microsoft.Rest;

namespace ConsoleApplication1
{
    class Program
    {

        private const string ClientId = "9441e260-82fc-4cf2-a64b-68f3bc9f23e2";
        private const string BaseUri = "https://api.azuredatacatalog.com/catalogs";
        private static readonly Settings Settings = new Settings("TestDir", "2016-03-30");
        static void Main()
        {
            AdcAuthenticationContext authContext = new AdcAuthenticationContext(ClientId);
            ServiceClientCredentials creds = new TokenCredentials(authContext.AccessToken().Result.AccessToken);
            var restClient = new DataCatalogRestClient(new Uri(BaseUri), creds);

            var tableToRegister = new Table("testsdkmaxli",
                new Dsl("tds",
                    new Dictionary<string, string>
                    {
                        {"server", "abcmaxliaaa.com"},
                        {"database", "test"},
                        {"schema", "test"},
                        {"object", "test"}
                    }, "windows"), new DataSource("SQL Server", "Table"),
                new LastRegisteredBy("maxli@microsoft.com"), false,
                friendlyName: new FriendlyName("namefromp", false),
                roles:
                    new[]
                    {new RolesItem(Role.Contributor, new[] {new MembersItem("00000000-0000-0000-0000-000000000201")})});

            var tableAdd = restClient.Table.Register(tableToRegister, Settings);
            var tableId = tableAdd.Location.Split('/').LastOrDefault();
            var tabGet = restClient.Table.Get(tableId, Settings);

            restClient.TryChangeClientUriWithLocation(tableAdd.Location);

            // Add, get, update, delete description
            var desAdd = restClient.Table.AddDescription(tableId, new Description("Desc", false, "--desc"), Settings);
            var desId = desAdd.Location.Split('/').LastOrDefault();
            var desGet = restClient.Table.GetDescription(tableId, desId, Settings);
            var desUp = restClient.Table.UpdateDescription(tableId, desId, new Description("Desc updated", false, desGet.Key), Settings);
            var desDel = restClient.Table.DeleteDescription(tableId, desId, Settings);

            // Add, get, update, delete tag
            var tagAdd = restClient.Table.AddTag(tableId, new Tag("Tag", false, "--tag"), Settings);
            var tagId = tagAdd.Location.Split('/').LastOrDefault();
            var tagGet = restClient.Table.GetTag(tableId, tagId, Settings);
            var tagUp = restClient.Table.UpdateTag(tableId, tagId, new Tag("Tag updated", false, tagGet.Key), Settings);
            var tagDel = restClient.Table.DeleteTag(tableId, tagId, Settings);

            tabGet = restClient.Table.Get(tableId, Settings);
            // Delete table
            var tableDel = restClient.Table.Delete(tableId, Settings);
        }
    }
}
