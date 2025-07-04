using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Context
{
    public class SalesDapperContext : ISalesDapperContext
    {
        private readonly string _connectionString;

        public SalesDapperContext(IOptionsMonitor<DapperContextOptions> options)
        {
            _connectionString = options.Get("Sales")?.ConnectionString
                ?? throw new ArgumentNullException("Sales connection string not found.");
        }

        public IDbConnection Connection => new SqlConnection(_connectionString);
    }
}
