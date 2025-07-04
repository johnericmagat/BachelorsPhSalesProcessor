using BachelorsPhSalesProcessor.Infrastructure.Dapper.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Extensions
{
    public static class DapperServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperContexts(this IServiceCollection services, IConfiguration configuration)
        {
            // Bind named options
            services.Configure<DapperContextOptions>("Sales", configuration.GetSection("ConnectionStrings:SalesDB").ToDapperOption());
            services.Configure<DapperContextOptions>("BrbRaw", configuration.GetSection("ConnectionStrings:BrbRawDB").ToDapperOption());

            // Register context classes
            services.AddTransient<ISalesDapperContext, SalesDapperContext>();
            services.AddTransient<IBrbRawDapperContext, BrbRawDapperContext>();

            return services;
        }

        // Helper to wrap a string connection into IOptions section
        private static IConfigurationSection ToDapperOption(this IConfigurationSection section)
        {
            return new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string?>
                {
                { "ConnectionString", section.Value }
                })
                .Build()
                .GetSection("");
        }
    }
}
