using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;

namespace BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw
{
    public interface ISalesRawService
    {
        Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync();
        Task<SalesRawResponseDto> GetSalesRawDetailByPublicIdAsync(string publicId);
    }
}
