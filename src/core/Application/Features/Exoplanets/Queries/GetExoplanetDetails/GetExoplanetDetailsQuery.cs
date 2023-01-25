using MediatR;

namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetDetails
{
   public class GetExoplanetDetailsQuery : IRequest<ExoplanetDetailVm>
   {
      public Guid ExoplanetId { get; set; }
   }
}
