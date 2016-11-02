using SchoolPlan.Data.Mappers;
using System.Data.Entity;
using System.Reflection.Emit;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.Data
{

    public class SchoolPlanContext : DbContext
    {
        public SchoolPlanContext()
            : base("name=SchoolPlanContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolPlanContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SchoolPlanContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolPlanContext, SchoolPlanContextConfiguration>());
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeacherMapper());
            modelBuilder.Configurations.Add(new LocationMapper());
            modelBuilder.Configurations.Add(new ClassMapper());
            modelBuilder.Configurations.Add(new StudentMapper());
            modelBuilder.Configurations.Add(new StudentClassMapper());
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
