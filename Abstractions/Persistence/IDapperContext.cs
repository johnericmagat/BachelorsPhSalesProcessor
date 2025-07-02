using System.Data;

namespace BachelorsPhSalesProcessor.Abstractions.Persistence
{
    public interface IDapperContext
    {
        IDbConnection DatabaseConnection { get; }
    }
}
