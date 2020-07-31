using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIApp.Configurations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DigitalBankDBContext>
    {
        public DigitalBankDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DigitalBankDBContext>();

            var connectionString = configuration.GetConnectionString("DIGITALBANKDB");

            builder.UseMySql(connectionString);

            return new DigitalBankDBContext(builder.Options);
        }
    }
}
