using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.Data.Mappers
{
    public class LocationMapper : EntityTypeConfiguration<Location>
    {
        public LocationMapper()
        {
            ToTable("Location");

            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Id).IsRequired();

            Property(t => t.BuildingNumber).IsRequired();
            Property(t => t.RoomNumber).IsRequired();

            Property(t => t.CreationDate).IsOptional();
            Property(t => t.ModificationDate).IsOptional();
        }
    }
}
