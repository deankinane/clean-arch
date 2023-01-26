using MediatR;

namespace CleanArch.Application.Features.Stars.Queries.GetStarDetails
{
   public class GetStarDetailsQuery : IRequest<StarDetailVm>
   {
       public Guid Id { get; set; }
   } 
}
