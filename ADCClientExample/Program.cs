// Microsoft Azure Data Catalog team SDK sample

using Microsoft.Azure.DataCatalog.Rest;
using Microsoft.Azure.DataCatalog.Rest.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using AzureDataCatalogSDK.Authentication;

namespace ADCClientExample
{
    internal class Program
    {
        // TODO: Replace the Client ID placeholder with a client ID authorized to access your Azure Active Directory
        // To learn how to register a client app and get a Client ID, see https://msdn.microsoft.com/library/azure/mt403303.aspx
        private const string CatalogName = "DefaultCatalog";

        private static readonly Settings Settings = new Settings(CatalogName, "2016-03-30");

        private static void Main(string[] args)
        {
            var container = Bootstrapper.Initialize(args);
            var tokenProvider = container.Resolve<ICachedADCTokenProvider>();
            var token = tokenProvider.GetToken().GetAwaiter().GetResult();

            var restClient = container.Resolve<IDataCatalogRestClient>();
            restClient.SetCredentials(token);

            var tableToRegister = new Table(name: "testtable", dsl: new Dsl("tds",
                new Dictionary<string, string>
                {
                    {"server", "abcmaxliaaa.com"},
                    {"database", "test"},
                    {"schema", "test"},
                    {"object", "test"}
                }, "windows"), dataSource: new DataSource("SQL Server", "Table"), fromSourceSystem: false, friendlyName: new FriendlyName("namefromp", false),
                roles: new[]
                {new RolesItem(Role.Contributor, new[] {new MembersItem("00000000-0000-0000-0000-000000000201")})},
                lastRegisteredBy: new LastRegisteredBy("4af87177-3ba9-4813-a7f1-dd1bc81e23d3@d9ce8388-5b6d-4e84-8f48-c36a5f18c794"));

            var tableAdd = restClient.Table.Register(tableToRegister, Settings);
            var tableId = tableAdd.Location.Split('/').LastOrDefault();
            var tabGet = restClient.Table.Get(tableId, Settings);

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