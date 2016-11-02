using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.Data.Mappers
{
    public class StudentClassMapper : EntityTypeConfiguration<StudentClass>
    {
        public StudentClassMapper()
        {
            ToTable("StudentClass");

            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Id).IsRequired();

            Property(c => c.CreationDate).IsOptional();

            Property(c => c.ModificationDate).IsOptional();
        }
    }
}
