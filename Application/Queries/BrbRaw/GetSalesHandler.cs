using BachelorsPhSalesProcessor.Abstractions.Persistence;
using BachelorsPhSalesProcessor.Dto.BrbRaw.Sales;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesHandler : IRequestHandler<GetSalesQuery, IEnumerable<SalesResponseDto>>
    {
        private readonly IBrbRawRepository _brbRawRepository;

        public GetSalesHandler(IBrbRawRepository brbRawRepository)
        {
            _brbRawRepository = brbRawRepository;
        }

        public async Task<IEnumerable<SalesResponseDto>> Handle(GetSalesQuery request, CancellationToken cancellationToken)
        {
            var result = await _brbRawRepository.GetSalesAsync();

            return result;
        }
    }
}
