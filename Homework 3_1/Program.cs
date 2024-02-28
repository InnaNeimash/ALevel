using Homework_3_1.Repository;
using Homework_3_1.Repository.Abstraction;
using Homework_3_1.Service;
using Homework_3_1.Service.Abstaction;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Homework_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ConfigureService(ServiceCollection serviceCollection)
            {
                serviceCollection
                    .AddScoped<IBookService, BookService>()
                    .AddScoped<IBookRepository, BookRepository>()
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
