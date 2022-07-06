using Database.Models.Contacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations.Contacts
{
    internal class ConfigurationPhone : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("Phones", "dbo.Contacts");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Number)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.IsCompany)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(p => p.IsShown)
                .IsRequired()
                .HasDefaultValue(true);
        }
    }
}
