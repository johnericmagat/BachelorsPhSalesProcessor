using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BachelorsPhSalesProcessor.Infrastructure.Sales
{
    public class SalesDbContextFactory : IDesignTimeDbContextFactory<SalesDbContext>
    {
        public SalesDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SalesDbContext>();
            var connectionString = config.GetConnectionString("SalesDB");

            optionsBuilder.UseSqlServer(connectionString);

            return new SalesDbContext(optionsBuilder.Options);
        }
    }
}
