using MediatR;

namespace CleanArch.Application.Features.Stars.Commands.CreateStar
{
   public class CreateStarCommand : IRequest<Guid>
   {
      public string Name { get; set; } = string.Empty;
      public string Class { get; set; } = string.Empty;
   }
}
