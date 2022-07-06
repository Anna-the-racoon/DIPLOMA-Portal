using Database.Models.HumanResources;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.HumanResource
{
    internal class ConfigurationEmployee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee", "dbo.HumanResources");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ExternalId)
                .IsRequired(false);

            builder.Property(p => p.BirthDay)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(300);

            builder.HasOne(p => p.Phone)
                .WithOne(p => p.Employee)
                .HasForeignKey<Employee>(p=>p.PrivatePhoneId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
           
            builder.HasOne(p => p.Phone)
                .WithOne(p => p.Employee)
                .HasForeignKey<Employee>(p => p.CompanyPhoneId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(p => p.Email)
                .IsRequired(false)
                .HasMaxLength(320);
        }
    }
}
