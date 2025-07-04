using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;

namespace BachelorsPhSalesProcessor.Abstractions.Persistence.BrbRaw
{
    public interface IBrbRawQueries
    {
        Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync();
        Task<SalesRawResponseDto> GetSalesRawDetailByPublicIdAsync(string publicId);
    }
}
