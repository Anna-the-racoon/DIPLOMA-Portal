using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecurityDatabase.Models;

namespace SecurityDatabase.Configurations
{
    internal class ConfigurationUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "dbo.Security");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(205);

            builder.HasIndex(p => p.Email)
                .IsUnique();

            builder.Property(p => p.Password)
                .IsRequired();

            builder.Property(p => p.Token)
                .IsRequired();

            builder.HasIndex(p => p.Token)
                .IsUnique();
        }
    }
}
