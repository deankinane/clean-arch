namespace CleanArch.Application.Features.Exoplanets.Queries.GetExoplanetsList
{
   public class ExoplanetListVm
   {
      public Guid Id { get; set; } 
      public string Name { get; set; } = string.Empty;
      public bool InHabitableZone { get; set; }
   }
}
