using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.CompilerServices;

namespace APIApp.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var serviceProvider = services.BuildServiceProvider();

            if (services == null) throw new ArgumentNullException(nameof(services));

            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<DigitalBankDBContext>((serviceProvider, options) => {
                options.UseMySql(configuration.GetConnectionString("DIGITALBANKDB"), providerOptions => providerOptions.EnableRetryOnFailure());
            });
        }
    }
}
