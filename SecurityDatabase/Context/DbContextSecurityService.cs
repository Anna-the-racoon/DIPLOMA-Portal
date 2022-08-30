using Microsoft.EntityFrameworkCore;
using SecurityDatabase.Configurations;
using SecurityDatabase.Models;

namespace Database.Context
{
    internal class DbContextSecurityService : DbContext
    {
        #region
        //public DbSet<Имя модели таблицы> Название самой таблицы { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        #endregion

        public DbContextSecurityService() {}

        public DbContextSecurityService(DbContextOptions<DbContextSecurityService> options)
            : base(options)
        { }


        protected override void OnConfiguring(DbContextOptionsBuilder options) => options
            .UseSqlServer(@"Server=DESKTOP-K2BKJ4P\SQLEXPRESS;Database=Security;Trusted_Connection=True;");
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationUser());

            modelBuilder.ApplyConfiguration(new ConfigurationRole());

            modelBuilder.ApplyConfiguration(new ConfigurationPermission());
        }
    }
}
