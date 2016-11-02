using System;
using System.Collections.Generic;

namespace SchoolPlan.DataAccess.Interface.Models
{
    public class Class
    {
        public Class()
        {
            StudentClasses = new List<StudentClass>();
            Teacher = new Teacher();
            Location = new Location();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Location Location { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
