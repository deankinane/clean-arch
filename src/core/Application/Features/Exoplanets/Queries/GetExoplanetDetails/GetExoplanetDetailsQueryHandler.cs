using AutoMapper;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Application.Exceptions;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetDetails
{
    public class GetExoplanetDetailQueryHandler : ApplicationRequestHandler<GetExoplanetDetailsQuery, ExoplanetDetailVm>
    {
        private readonly IExoplanetRepository exoplanetRepository;
        private readonly IAsyncRepository<Star> starRepository;

        public GetExoplanetDetailQueryHandler(
            IMapper mapper,
            IExoplanetRepository exoplanetRepository,
            IAsyncRepository<Star> starRepository) : base(mapper)
        {
            this.exoplanetRepository = exoplanetRepository;
            this.starRepository = starRepository;
        }

        public override async Task<ExoplanetDetailVm> Handle(
            GetExoplanetDetailsQuery request,
            CancellationToken cancellationToken)
        {
           var planet = await exoplanetRepository.GetByIdAsync(request.ExoplanetId); 
           if (planet == null)
           {
               throw new NotFoundException(typeof(Exoplanet).Name, request.ExoplanetId);
           }
           
           var star = await starRepository.GetByIdAsync(planet.StarId);
           
           var planetVm = _mapper.Map<ExoplanetDetailVm>(planet);
           planetVm.Star = _mapper.Map<StarDto>(star);
           
           return planetVm;
        }
    }
}
   
