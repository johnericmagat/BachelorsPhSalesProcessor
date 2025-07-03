using BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw;
using BachelorsPhSalesProcessor.Application.Queries.BrbRaw;
using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;
using MediatR;

namespace BachelorsPhSalesProcessor.Services.BrbRaw
{
    public class SalesService : ISalesService
    {
        private readonly IMediator _mediator;

        public SalesService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<SalesResponseDto>> GetSalesAsync()
        {
            var command = new GetSalesQuery();
            var result = await this._mediator.Send(command);

            return result;
        }
    }
}
