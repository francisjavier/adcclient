using Autofac;
using Autofac.Extensions.DependencyInjection;
using AzureDataCatalogSDK.Authentication;
using LazyCache;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using IContainer = Autofac.IContainer;

namespace ADCClientExample
{
    public class Bootstrapper
    {
        public static IContainer Initialize(string[] args)
        {
            var configuration = BuildConfiguration(args);
            var container = BuildContainer(configuration);

            return container;
        }

        private static IContainer BuildContainer(IConfiguration configuration)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLazyCache(provider => new CachingService(new Lazy<ICacheProvider>(provider.GetRequiredService<ICacheProvider>())));

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterAssemblyTypes(typeof(Bootstrapper).Assembly).AsImplementedInterfaces();
            containerBuilder.RegisterAssemblyTypes(typeof(ADCTokenProvider).Assembly).AsImplementedInterfaces();
            containerBuilder.RegisterInstance(configuration).As<IConfiguration>();

            containerBuilder.Populate(serviceCollection);

            var container = containerBuilder.Build();
            return container;
        }

        private static IConfiguration BuildConfiguration(string[] args)
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
        }
    }
}