using HrService.Database.Models.OrgStructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrService.Database.Configurations.OrgStructure
{
    internal class ConfigurationPosition : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Positions", "dbo.OrgStructure");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ExternalId)
                .IsRequired(false);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(p => p.IsActual)
                .IsRequired()
                .HasDefaultValue(true);
            
            builder.Property(p => p.IsManager)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
