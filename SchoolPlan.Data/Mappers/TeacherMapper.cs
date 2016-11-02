using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.Data.Mappers
{
    public class TeacherMapper : EntityTypeConfiguration<Teacher>
    {
        public TeacherMapper()
        {
            ToTable("Teacher");

            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Id).IsRequired();

            Property(t => t.FirstName).IsRequired();
            Property(t => t.FirstName).HasMaxLength(50);

            Property(t => t.LastName).IsRequired();
            Property(t => t.LastName).HasMaxLength(50);

            Property(t => t.CreationDate).IsOptional();
            Property(t => t.ModificationDate).IsOptional();
        }
    }
}
