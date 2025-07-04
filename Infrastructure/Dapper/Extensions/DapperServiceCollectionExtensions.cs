using BachelorsPhSalesProcessor.Infrastructure.Dapper.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Extensions
{
    public static class DapperServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DapperContextOptions>("Sales", o =>
                o.ConnectionString = configuration.GetConnectionString("SalesDB"));

            services.Configure<DapperContextOptions>("BrbRaw", o =>
                o.ConnectionString = configuration.GetConnectionString("BrbRawDB"));

            services.AddTransient<ISalesDapperContext, SalesDapperContext>();
            services.AddTransient<IBrbRawDapperContext, BrbRawDapperContext>();

            return services;
        }
    }
}
