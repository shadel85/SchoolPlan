using System;
using System.Collections.Generic;

namespace SchoolPlan.Web.Models
{
    public class Class
    {
        public int ClassId { get; set; }

        public string Name { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Location Location { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual IEnumerable<StudentClass> StudentClasses { get; set; }
    }
}
