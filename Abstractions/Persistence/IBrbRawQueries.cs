using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;

namespace BachelorsPhSalesProcessor.Abstractions.Persistence
{
    public interface IBrbRawQueries
    {
        Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync();
    }
}
