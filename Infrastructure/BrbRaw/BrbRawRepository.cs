using BachelorsPhSalesProcessor.Abstractions.Persistence.BrbRaw;
using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using BachelorsPhSalesProcessor.Infrastructure.Dapper.Context;
using Dapper;
using Microsoft.Extensions.Logging;
using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure.BrbRaw
{
    public class BrbRawRepository : IBrbRawRepository
    {
        private readonly IBrbRawDapperContext _queryContext;
        private readonly ILogger<BrbRawRepository> _logger;

        public BrbRawRepository(IBrbRawDapperContext queryContext, ILogger<BrbRawRepository> logger)
        {
            _queryContext = queryContext;
            _logger = logger;
        }

        public async Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync()
        {
            try
            {
                using (var connection = _queryContext.Connection)
                {
                    var parameters = new DynamicParameters();

                    var salesRaw = (await connection.QueryAsync<SalesRawResponseDto>("GetSalesRaw", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    return salesRaw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public async Task<SalesRawResponseDto> GetSalesRawDetailByPublicIdAsync(string publicId)
        {
            try
            {
                using (var connection = _queryContext.Connection)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@PublicId", publicId);

                    var salesRawDetail = (await connection.QueryAsync<SalesRawResponseDto>("GetSalesRawDetailByPublicId", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    return salesRawDetail.FirstOrDefault();
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
