using MediatR;

namespace CleanArch.Application.Features.Exoplanets.Commands.CreateExoplanet
{
    public class CreateExoplanetCommand : IRequest<CreateExoplanetCommandResponse>
    {
      public string Name { get; set; } = string.Empty;
      public DateTime Discovered { get; set; }
      public bool InHabitableZone { get; set; }
      public string? Description { get; set; }
      public Guid StarId { get; set; }
    }
}
