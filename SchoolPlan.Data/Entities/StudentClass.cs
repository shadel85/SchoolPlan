namespace SchoolPlan.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentClass")]
    public partial class StudentClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentClassID { get; set; }

        public int StudentID { get; set; }

        public int ClassID { get; set; }

        public decimal? GPA { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Class Class { get; set; }

        public virtual Student Student { get; set; }
    }
}
