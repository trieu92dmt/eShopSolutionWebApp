using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopDBContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {
        public EShopDBContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<EShopDBContext>();
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(@"Server=MINHTRIEU\SQLEXPRESS01;Database=eShopSolution;Trusted_Connection=True;");

            return new EShopDBContext(optionsBuilder.Options);
        }
    }
}
