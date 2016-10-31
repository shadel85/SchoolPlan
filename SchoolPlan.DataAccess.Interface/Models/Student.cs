using System;
using System.Collections.Generic;

namespace SchoolPlan.DataAccess.Interface.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int? Age { get; set; }

        public virtual IEnumerable<StudentClass> StudentClasses { get; set; }
    }
}
