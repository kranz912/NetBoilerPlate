using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.DatabaseSeeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //register DB Connection Factory
            services.AddSingleton<IDBConnectionFactory, DBConnectionFactory>();
            services.AddSingleton<Seeder>();
            //register Services
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            //Add other infrastructure services


            return services;
        }
    }
}
