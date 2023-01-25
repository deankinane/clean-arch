namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetDetails
{
   public class ExoplanetDetailVm
   {
      public Guid Id { get; set; }
      public string Name { get; set; } = string.Empty;
      public string Description { get; set; } = string.Empty;
      public DateTime DateDiscovered { get; set; }
      public bool InHabitableZone { get; set; }
      public StarDto Star { get; set; } = default!;
   }
}
