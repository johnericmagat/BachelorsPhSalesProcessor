﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Context
{
    public class BrbRawDapperContext : IBrbRawDapperContext
    {
        private readonly string _connectionString;

        public BrbRawDapperContext(IOptionsMonitor<DapperContextOptions> options)
        {
            _connectionString = options.Get("BrbRaw")?.ConnectionString
                ?? throw new ArgumentNullException("BrbRaw connection string not found.");
        }

        public IDbConnection Connection => new SqlConnection(_connectionString);
    }
}
