using CleanArch.Domain.Common;

namespace CleanArch.Domain.Entities
{
   public class Exoplanet : AuditableEntity
   {
      public Guid Id { get; set; } 
      public string Name { get; set; } = string.Empty;
      public DateTime Discovered { get; set; }
      public bool InHabitableZone { get; set; }
      public string? Description { get; set; }
      public Guid StarId { get; set; }
   } 
}
