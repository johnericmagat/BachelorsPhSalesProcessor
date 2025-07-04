using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Context
{
    public interface ISalesDapperContext
    {
        IDbConnection Connection { get; }
    }
}
