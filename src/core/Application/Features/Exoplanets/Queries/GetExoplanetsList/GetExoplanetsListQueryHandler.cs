using AutoMapper;
using CleanArch.Application.Contracts.Persistence;

namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetsList
{
    public class GetExoplanetListQueryHandler : ApplicationRequestHandler<GetExoplanetListQuery, List<ExoplanetListVm>>
    {
        private readonly IExoplanetRepository _exoplanetRepository;

        public GetExoplanetListQueryHandler(IMapper mapper, IExoplanetRepository exoplanetRepository) : base(mapper)
        {
            this._exoplanetRepository = exoplanetRepository;
        }

        public override async Task<List<ExoplanetListVm>> Handle(
            GetExoplanetListQuery request,
            CancellationToken cancellationToken)
        {
            var allPlanets = await _exoplanetRepository.ListAllAsync();
            return _mapper.Map<List<ExoplanetListVm>>(allPlanets);
        }
    }
}
