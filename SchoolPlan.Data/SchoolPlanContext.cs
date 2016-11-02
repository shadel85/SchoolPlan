using SchoolPlan.Data.Mappers;
using System.Data.Entity;
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
            //modelBuilder.Configurations.Add(new LocationMapper());
            //modelBuilder.Configurations.Add(new StudentMapper());
            //modelBuilder.Configurations.Add(new StudentClassMapper());
            //modelBuilder.Configurations.Add(new TeacherMapper());

            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Class>()
            //    .HasKey(e => e.ClassID);

            //modelBuilder.Entity<Class>()
            //    .Property(e => e.ClassID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Class>()
            //    .Property(e => e.Name)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Class>()
            //    .HasMany(e => e.StudentClasses)
            //    .WithRequired(e => e.Class)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Class>().ToTable("Class");

            //modelBuilder.Entity<Location>()
            // .HasKey(e => e.LocationID);

            //modelBuilder.Entity<Location>()
            //    .Property(e => e.LocationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Location>()
            //    .HasMany(e => e.Classes)
            //    .WithRequired(e => e.Location)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Class>().ToTable("Location");

            //modelBuilder.Entity<Student>()
            //     .HasKey(e => e.StudentID);

            //modelBuilder.Entity<Student>()
            //    .Property(e => e.StudentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Student>()
            //    .Property(e => e.FirstName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Student>()
            //    .Property(e => e.LastName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Student>()
            //    .HasMany(e => e.StudentClasses)
            //    .WithRequired(e => e.Student)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Class>().ToTable("Student");

            //modelBuilder.Entity<StudentClass>()
            //    .HasKey(e => e.StudentClassID);

            //modelBuilder.Entity<StudentClass>()
            //    .Property(e => e.StudentClassID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<StudentClass>()
            //    .Property(e => e.GPA)
            //    .HasPrecision(5, 2);
            //modelBuilder.Entity<Class>().ToTable("StudentClass");

            //modelBuilder.Entity<Teacher>()
            //    .HasKey(e => e.TeacherID);

            //modelBuilder.Entity<Teacher>()
            //    .Property(e => e.TeacherID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Teacher>()
            //    .Property(e => e.FirstName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Teacher>()
            //    .Property(e => e.LastName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Teacher>()
            //    .HasMany(e => e.Classes)
            //    .WithRequired(e => e.Teacher)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Class>().ToTable("Teacher");

            base.OnModelCreating(modelBuilder);
        }
    }
}
