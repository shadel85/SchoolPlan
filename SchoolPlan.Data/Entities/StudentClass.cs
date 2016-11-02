using System;
namespace SchoolPlan.Data.Entities
{
    public class StudentClass
    {
        public StudentClass()
        {
            Student = new Student();
            Class = new Class();
        }
        public int Id { get; set; }

        public decimal? GPA { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Class Class { get; set; }

        public Student Student { get; set; }
    }
}
