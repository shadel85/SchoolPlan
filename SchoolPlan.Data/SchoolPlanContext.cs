namespace SchoolPlan.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;
    using Migrations;
    public partial class SchoolPlanContext : DbContext
    {
        public SchoolPlanContext()
            : base("name=SchoolPlanContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolPlanContext, Configuration>());
        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>()
                .HasKey(e => e.BuildingID);

            modelBuilder.Entity<Building>()
                .Property(e => e.BuildingID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Building>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasKey(e => e.ClassID);

            modelBuilder.Entity<Class>()
                .Property(e => e.ClassID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Class>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.StudentClasses)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
             .HasKey(e => e.RoomID);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                 .HasKey(e => e.StudentID);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentClasses)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentClass>()
                .HasKey(e => e.StudentClassID);

            modelBuilder.Entity<StudentClass>()
                .Property(e => e.StudentClassID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<StudentClass>()
                .Property(e => e.GPA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Teacher>()
                .HasKey(e => e.TeacherID);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.TeacherID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
