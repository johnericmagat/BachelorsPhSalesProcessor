using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;

namespace BachelorsPhSalesProcessor.Abstractions.Persistence
{
    public interface IBrbRawQueries
    {
        Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync();
    }
}
