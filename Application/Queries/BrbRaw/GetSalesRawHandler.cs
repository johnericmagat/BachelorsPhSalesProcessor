using BachelorsPhSalesProcessor.Abstractions.Persistence;
using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesRawHandler : IRequestHandler<GetSalesRawQuery, IEnumerable<SalesRawResponseDto>>
    {
        private readonly IBrbRawRepository _brbRawRepository;

        public GetSalesRawHandler(IBrbRawRepository brbRawRepository)
        {
            _brbRawRepository = brbRawRepository;
        }

        public async Task<IEnumerable<SalesRawResponseDto>> Handle(GetSalesRawQuery request, CancellationToken cancellationToken)
        {
            var result = await _brbRawRepository.GetSalesRawAsync();

            return result;
        }
    }
}
