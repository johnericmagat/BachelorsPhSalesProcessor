using Microsoft.Data.SqlClient;
using Polly;
using Polly.Retry;

namespace BachelorsPhSalesProcessor.Helper
{
    public static class DatabaseConnectionHelper
    {
        private static readonly AsyncRetryPolicy RetryPolicy = Policy
            .Handle<SqlException>(ex =>
            ex.Number == -2 ||      // SQL timeout
            ex.Number == 10053 ||   // Connection aborted
            ex.Number == 10054      // Connection reset
            )
            .WaitAndRetryAsync(
                retryCount: 5,
                sleepDurationProvider: attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt)),
                onRetry: (exception, delay, retryCount, context) =>
                {
                    Console.WriteLine($"Retry {retryCount} encountered {exception.GetType().Name}. Waiting {delay} before next retry.");
                });

        public static async Task EnsureDatabaseAvailability(Func<Task> action)
        {
            await RetryPolicy.ExecuteAsync(action);
        }
    }
}
