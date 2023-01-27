using CleanArch.Domain.Common;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Star> Stars { get; set; } = default!;
        public DbSet<Exoplanet> Exoplanets { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            var star = new Star()
            {
                Id = Guid.NewGuid(),
                Name = "Alpha Centauri",
                Class = "A"
            };

            var exoplanet = new Exoplanet()
            {
                Id = Guid.NewGuid(),
                Name = "Alpha Centauri A",
                Discovered = DateTime.Parse("20151010"),
                InHabitableZone = false,
                StarId = star.Id,
                Description = "A very nice planet!"
            };

            modelBuilder.Entity<Star>().HasData(star);
            modelBuilder.Entity<Exoplanet>().HasData(exoplanet);
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
           foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
           {
               switch (entry.State)
               {
                   case EntityState.Added:
                       entry.Entity.CreatedDate = DateTime.Now;
                       break;
                   case EntityState.Modified:
                       entry.Entity.LastModifiedDate = DateTime.Now;
                       break;
               }
           } 
           
           return base.SaveChangesAsync(cancellationToken);
        }
    }
}
