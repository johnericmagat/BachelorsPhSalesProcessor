using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesRawQuery : IRequest<IEnumerable<SalesRawResponseDto>>
    {
        public GetSalesRawQuery()
        {
        }
    }
}
