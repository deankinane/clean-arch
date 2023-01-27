using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Persistence.Configurations
{
    internal class StarConfiguration : IEntityTypeConfiguration<Star>
    {
        public void Configure(EntityTypeBuilder<Star> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);
            
            builder
                .Property(x => x.Class)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
