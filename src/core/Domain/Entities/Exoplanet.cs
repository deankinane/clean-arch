using CleanArch.Domain.Common;

namespace CleanArch.Domain.Entities
{
   public class Exoplanet : AuditableEntity
   {
      public int Id { get; set; } 
      public string Name { get; set; } = string.Empty;
      public DateTime Discovered { get; set; }
      public bool InHabitableZone { get; set; }
      public string? Description { get; set; }
   } 
}
