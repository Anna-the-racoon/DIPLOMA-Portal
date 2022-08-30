using Database.Configurations.Contacts;
using Database.Configurations.HumanResource;
using Database.Models.Contacts;
using Database.Models.HumanResources;
using HrService.Database.Configurations.OrgStructure;
using HrService.Database.Models.OrgStructure;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    internal class DbContextHrService : DbContext
    {
        #region
        //public DbSet<Имя модели таблицы> Название самой таблицы { get; set; }

        #region Contacts
        public DbSet<Phone> Phones { get; set; }
        #endregion

        #region HumanResources
        public DbSet<Employee> Employees { get; set; }
        #endregion

        #region OrgStructure
        public DbSet<Position> Positions { get; set; }

        public DbSet<Department> Departments { get; set; }
        #endregion

        #endregion

        public DbContextHrService(DbContextOptions<DbContextHrService> options)
            : base(options)
        { }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseLazyLoadingProxies(false);
            if (!options.IsConfigured) // <- без проверки возникает ошибка во время запуска тестов 'Multiple database providers in service provider'. InMemory создает свою конфигурацию.
            {
                options.UseSqlServer(@"Server=DESKTOP-K2BKJ4P\SQLEXPRESS;Database=Portal;Trusted_Connection=True;;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //разобраться, что именно это дает. взято у Ак Барса
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new Имя таблицы);

            #region Contacts
            modelBuilder.ApplyConfiguration(new ConfigurationPhone());
            #endregion

            #region HumanResource
            modelBuilder.ApplyConfiguration(new ConfigurationEmployee());
            #endregion

            #region OrgStructure
            modelBuilder.ApplyConfiguration(new ConfigurationPosition());

            modelBuilder.ApplyConfiguration(new ConfigurationDepartment());
            #endregion
        }
    }
}
