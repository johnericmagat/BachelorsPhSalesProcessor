using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesQuery : IRequest<IEnumerable<SalesResponseDto>>
    {
        public GetSalesQuery()
        {
        }
    }
}
