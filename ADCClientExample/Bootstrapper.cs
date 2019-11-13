using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Extensions.Configuration;
using IContainer = Autofac.IContainer;

namespace ADCClientExample
{
    public class Bootstrapper
    {
        public static IContainer Initialize(string[] args)
        {
            var configuration = BuildConfiguration(args);
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
