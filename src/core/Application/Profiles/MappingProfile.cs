using AutoMapper;
using CleanArch.Application.Features.Exoplanets.Queries;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Profiles
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<Exoplanet, ExoplanetListVm>();
            CreateMap<Exoplanet, ExoplanetDetailVm>().ReverseMap();
            CreateMap<Star, StarDto>();
        }
    }
}
