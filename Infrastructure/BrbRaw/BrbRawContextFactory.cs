﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BachelorsPhSalesProcessor.Infrastructure.BrbRaw
{
    public class BrbRawContextFactory : IDesignTimeDbContextFactory<BrbRawDbContext>
    {
        public BrbRawDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BrbRawDbContext>();
            var connectionString = config.GetConnectionString("BrbRawDB");

            optionsBuilder.UseSqlServer(connectionString);

            return new BrbRawDbContext(optionsBuilder.Options);
        }
    }
}
