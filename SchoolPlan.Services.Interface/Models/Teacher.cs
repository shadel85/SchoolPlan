using System;
using System.Collections.Generic;

namespace SchoolPlan.Services.Interface.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual IEnumerable<Class> Classes { get; set; }
    }
}
