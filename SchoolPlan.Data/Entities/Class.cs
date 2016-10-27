namespace SchoolPlan.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int RoomID { get; set; }

        public int TeacherID { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Room Room { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
