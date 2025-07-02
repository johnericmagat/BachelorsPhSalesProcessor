using BachelorsPhSalesProcessor.Abstractions.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace BachelorsPhSalesProcessor.Infrastructure
{
    public static class DapperExtensions
    {
        public static IServiceCollection AddDapperContext(this IServiceCollection services, Action<DapperContextOptions> optionsAction)
        {
            services.Configure(optionsAction);

            services.AddTransient<IDapperContext, AppQueryContext>();

            return services;
        }
    }
}
