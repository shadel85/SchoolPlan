namespace SchoolPlan.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            Classes = new HashSet<Class>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }

        [Required]
        public int BuildingNumber { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
