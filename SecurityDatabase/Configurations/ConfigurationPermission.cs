using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecurityDatabase.Models;

namespace SecurityDatabase.Configurations
{
    internal class ConfigurationPermission : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions", "dbo.Security");

            builder.HasKey(p => new { p.UserId, p.RoleId });

            builder.HasOne(sc => sc.User)
                .WithMany(s => s.Permissions)
                .HasForeignKey(sc => sc.UserId);

            builder.HasOne(sc => sc.Role)
                .WithMany(s => s.Permissions)
                .HasForeignKey(sc => sc.RoleId);
        }
    }
}
