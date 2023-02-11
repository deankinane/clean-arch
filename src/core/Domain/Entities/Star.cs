using CleanArch.Domain.Common;

namespace CleanArch.Domain.Entities
{
   public class Star : AuditableEntity
   {
      public Guid Id { get; set; }
      public string Name { get; set; } = string.Empty;
      public string Class { get; set; } = string.Empty;
   }
}
