using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Stars.Queries.GetStarDetails
{
    public class GetStarDetailsQueryHandler : ApplicationRequestHandler<GetStarDetailsQuery, StarDetailVm>
    {
        private readonly IAsyncRepository<Star> starRepository;

        public GetStarDetailsQueryHandler(
            IMapper mapper,
            IAsyncRepository<Star> starRepository) : base(mapper)
        {
            this.starRepository = starRepository;
        }

        public override async Task<StarDetailVm> Handle(
            GetStarDetailsQuery request,
            CancellationToken cancellationToken)
        {
           return _mapper.Map<StarDetailVm>(await starRepository.GetByIdAsync(request.Id));
        }
    }
}
