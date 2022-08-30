using HrService.Database.Models.HumanResources;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrService.Database.Configurations.HumanResource
{
    internal class ConfigurationAssignment : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments", "dbo.HumanResources");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            //builder.HasOne(p => p.Employee)
            //    .WithMany(p => p.Assignment);
        }
    }
}
