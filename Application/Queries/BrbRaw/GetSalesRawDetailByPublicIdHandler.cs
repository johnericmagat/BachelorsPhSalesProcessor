using BachelorsPhSalesProcessor.Abstractions.Persistence.BrbRaw;
using BachelorsPhSalesProcessor.Dto.BrbRaw.SalesRaw;
using MediatR;

namespace BachelorsPhSalesProcessor.Application.Queries.BrbRaw
{
    public class GetSalesRawDetailByPublicIdHandler : IRequestHandler<GetSalesRawDetailByPublicIdQuery, SalesRawResponseDto>
    {
        private readonly IBrbRawRepository _brbRawRepository;

        public GetSalesRawDetailByPublicIdHandler(IBrbRawRepository brbRawRepository)
        {
            _brbRawRepository = brbRawRepository;
        }

        public async Task<SalesRawResponseDto> Handle(GetSalesRawDetailByPublicIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _brbRawRepository.GetSalesRawDetailByPublicIdAsync(request._publicId);

            return result;
        }
    }
}
