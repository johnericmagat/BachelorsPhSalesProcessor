using BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw;
using BachelorsPhSalesProcessor.Application.Queries.BrbRaw;
using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using MediatR;

namespace BachelorsPhSalesProcessor.Services.BrbRaw
{
    public class SalesRawService : ISalesRawService
    {
        private readonly IMediator _mediator;

        public SalesRawService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<SalesRawResponseDto>> GetSalesRawAsync()
        {
            var command = new GetSalesRawQuery();
            var result = await this._mediator.Send(command);

            return result;
        }
    }
}
