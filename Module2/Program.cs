using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module2.config;
using Module2.Repository;
using Module2.Repository.Abstraction;
using Module2.Services;
using Module2.Services.Abstraction;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ConfigureService(ServiceCollection serviceCollection, IConfiguration configuration)
            {
                serviceCollection.AddOptions<LogOption>().Bind(configuration.GetSection("Log"));
                serviceCollection
                    .AddScoped<IRepositoryApp, RepositoryApp>()
                    .AddScoped<IRoomService, RoomService>()
                    .AddSingleton<ILogService, LogService>()
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
