using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Stars.Queries.GetStarsList
{
    public class GetStarListQueryHandler : ApplicationRequestHandler<GetStarsListQuery, List<StarListVm>>
    {
        private readonly IAsyncRepository<Star> starRepository;

        public GetStarListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Star> starRepository) : base(mapper)
        {
            this.starRepository = starRepository;
        }

        public override async Task<List<StarListVm>> Handle(
            GetStarsListQuery request,
            CancellationToken cancellationToken)
        {
            return _mapper.Map<List<StarListVm>>(await starRepository.ListAllAsync());
        }
    }
}
