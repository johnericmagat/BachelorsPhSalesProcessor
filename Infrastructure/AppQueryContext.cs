using BachelorsPhSalesProcessor.Abstractions.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure
{
    public class AppQueryContext : IDapperContext
    {
        private IDbConnection? _databaseConnection { get; set; }
        private static string _connectionString = default!;

        public IDbConnection DatabaseConnection
        {
            get
            {
                _databaseConnection ??= new SqlConnection(_connectionString);

                return _databaseConnection;
            }
        }

        public AppQueryContext(IOptions<DapperContextOptions> contextOptions)
        {
            _connectionString = contextOptions.Value.ConnectionString;
            ArgumentException.ThrowIfNullOrWhiteSpace(_connectionString, nameof(_connectionString));
        }
    }
}
