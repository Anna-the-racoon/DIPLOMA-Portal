using HrService.Database.Models.OrgStructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrService.Database.Configurations.OrgStructure
{
    internal class ConfigurationDepartment : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo.OrgStructure");

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

            builder.Property(p => p.DateStart)
                .IsRequired();

            builder.Property(p => p.DateEnd)
                .IsRequired(false);

            builder.Property(p => p.ParentId)
                .IsRequired(false);

            builder.Property(p => p.Email)
                .IsRequired(false)
                .HasMaxLength(320);
        }
    }
}