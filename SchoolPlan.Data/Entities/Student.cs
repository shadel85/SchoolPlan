using System;
using System.Collections.Generic;

namespace SchoolPlan.Data.Entities
{
    public class Student
    {
        public Student()
        {
            StudentClasses = new List<StudentClass>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int? Age { get; set; }

        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
