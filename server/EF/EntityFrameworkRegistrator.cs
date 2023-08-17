using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public static class EntityFrameworkRegistrator
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services,
            string connectionString)
        {
            services
                .AddDbContext<BankContext>(o => o
                    .UseLazyLoadingProxies() // lazy loading
                    .UseNpgsql(connectionString));
            Console.WriteLine(services.Count);
            return services;
        }
    }
}
