using AutoMapper;
using CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet;
using CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetDetails;
using CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetsList;
using CleanArch.Application.Features.Stars.Commands.CreateStar;
using CleanArch.Application.Features.Stars.Queries.GetStarDetails;
using CleanArch.Application.Features.Stars.Queries.GetStarsList;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Profiles
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<Exoplanet, ExoplanetListVm>();
            CreateMap<Exoplanet, ExoplanetDetailVm>();
            CreateMap<CreateExoplanetCommand, Exoplanet>();
            
            CreateMap<Star, StarDto>();
            CreateMap<Star, StarListVm>();
            CreateMap<CreateStarCommand, Star>();
            CreateMap<Star, StarDetailVm>();
        }
    }
}
