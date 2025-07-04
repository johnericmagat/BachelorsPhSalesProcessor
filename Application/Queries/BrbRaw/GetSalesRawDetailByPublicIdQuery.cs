using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesRawDetailByPublicIdQuery : IRequest<SalesRawResponseDto>
    {
        public string _publicId { get; set; }

        public GetSalesRawDetailByPublicIdQuery(string publicId)
        {
            _publicId = publicId;
        }
    }
}
