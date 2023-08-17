using BusinessLogic.Services;
using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repositories.Abstarctions;
using DataAccess.Repositories.Implementations;
using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_DB.DI
{
    public static class DIFactory
    {
        public static IServiceProvider RegisterDI()
        {
            IServiceCollection services = new ServiceCollection();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration["ConnectionString"];
            services.ConfigureContext(connectionString);
            RegisterRepositories(services);
            RegisterServices(services);

            var serviceProvider = services.BuildServiceProvider();

            Console.WriteLine("Services Registered");
            return serviceProvider;

        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IClientRepository,ClientRepository>();
        }
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ClientService>();
        }
    }
}
