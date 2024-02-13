using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Salad.Models;
using Salad.Services;
using Salad.Services.Abstractions;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace Salad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ConfigureService(ServiceCollection serviceCollection, IConfiguration configuration)
            {
                serviceCollection
                    .AddScoped<ISaladService,SaladService>()
                    .AddTransient<Startup>();
            }
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection, configuration);
            var provider = serviceCollection.BuildServiceProvider();
            var startup = provider.GetService<Startup>();
            startup.Start();
        }
    }
}
