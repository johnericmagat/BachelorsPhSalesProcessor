using BachelorsPhSalesProcessor.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BachelorsPhSalesProcessor.Infrastructure
{
    public static class MigrateDatabaseExtension
    {
        public static void MigrateDatabases(IServiceProvider services, params Type[] dbContextTypes)
        {
            using var scope = services.CreateScope();

            foreach (var dbContextType in dbContextTypes)
            {
                var dbContext = (DbContext)scope.ServiceProvider.GetRequiredService(dbContextType);
                DatabaseConnectionHelper.EnsureDatabaseAvailability(() => dbContext.Database.MigrateAsync()).Wait();
            }
        }
    }
}
