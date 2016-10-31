using System;

namespace SchoolPlan.Web.Models
{
    public class StudentClass
    {
        public int StudentClassId { get; set; }

        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public decimal? GPA { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Class Class { get; set; }

        public virtual Student Student { get; set; }
    }
}
