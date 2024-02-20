using Homework_3_4_2.Repository;
using Homework_3_4_2.Repository.Abstraction;
using Homework_3_4_2.Service;
using Homework_3_4_2.Service.Abstaction;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Homework_3_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ConfigureService(ServiceCollection serviceCollection)
            {
                serviceCollection
                    .AddScoped<IPhoneBookService, PhoneBookService>()
                    .AddScoped<IPhoneBookRepository, PhoneBookRepository>()
                    .AddTransient<Startup>();
            }
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            var provider = serviceCollection.BuildServiceProvider();
            var startup = provider.GetService<Startup>();
            startup.Stat();
        }
    }
}
