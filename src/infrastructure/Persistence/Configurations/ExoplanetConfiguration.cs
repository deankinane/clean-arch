using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Persistence.Configurations
{
    internal class ExoplanetConfiguration : IEntityTypeConfiguration<Exoplanet>
    {
        public void Configure(EntityTypeBuilder<Exoplanet> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Description)
                .HasMaxLength(255);

            builder
                .Property(x => x.InHabitableZone)
                .IsRequired();

            builder
                .Property(x => x.Discovered)
                .IsRequired();

            builder
                .Property(x => x.StarId)
                .IsRequired();
        }
    }
}
