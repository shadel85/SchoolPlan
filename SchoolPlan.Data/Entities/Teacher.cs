using System;
using System.Collections.Generic;

namespace SchoolPlan.Data.Entities
{

    public class Teacher
    {
        public Teacher()
        {
            Classes = new List<Class>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
