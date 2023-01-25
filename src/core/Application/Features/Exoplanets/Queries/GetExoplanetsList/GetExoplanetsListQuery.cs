using MediatR;

namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetsList
{
   public class GetExoplanetListQuery : IRequest<List<ExoplanetListVm>>
   {
   }
}
