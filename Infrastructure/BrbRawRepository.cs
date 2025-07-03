using BachelorsPhSalesProcessor.Abstractions.Persistence;
using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;
using Dapper;
using Microsoft.Extensions.Logging;
using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure
{
    public class BrbRawRepository : IBrbRawRepository
    {
        private IDapperContext _queryContext { get; }
        private readonly ILogger<BrbRawRepository> _logger;

        public BrbRawRepository(IDapperContext queryContext, ILogger<BrbRawRepository> logger)
        {
            _queryContext = queryContext;
            _logger = logger;
        }

        public async Task<IEnumerable<SalesResponseDto>> GetSalesAsync()
        {
            try
            {
                using (var connection = _queryContext.DatabaseConnection)
                {
                    var parameters = new DynamicParameters();

                    var sales = (await connection.QueryAsync<SalesResponseDto>("GetSales", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    return sales;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}
