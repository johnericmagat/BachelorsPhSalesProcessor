using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;

namespace BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw
{
    public interface ISalesService
    {
        Task<IEnumerable<SalesResponseDto>> GetSalesAsync();
    }
}
