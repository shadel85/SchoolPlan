using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.Data.Mappers
{
    public class ClassMapper : EntityTypeConfiguration<Class>
    {
        public ClassMapper()
        {
            ToTable("Class");

            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Id).IsRequired();

            Property(c => c.Name).IsRequired();
            Property(c => c.Name).HasMaxLength(100);

            Property(c => c.CreationDate).IsOptional();

            Property(c => c.ModificationDate).IsOptional();
        }
    }
}
