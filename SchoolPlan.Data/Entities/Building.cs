namespace SchoolPlan.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Building")]
    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            Rooms = new HashSet<Room>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuildingID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
