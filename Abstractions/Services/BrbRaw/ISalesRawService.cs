using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;

namespace BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw
{
    public interface ISalesRawService
    {
        Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync();
    }
}
