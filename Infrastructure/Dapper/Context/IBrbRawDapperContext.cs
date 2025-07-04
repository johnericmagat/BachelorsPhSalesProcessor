using System.Data;

namespace BachelorsPhSalesProcessor.Infrastructure.Dapper.Context
{
    public interface IBrbRawDapperContext
    {
        IDbConnection Connection { get; }
    }
}
