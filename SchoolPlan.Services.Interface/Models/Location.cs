using System;
using System.Collections.Generic;

namespace SchoolPlan.Services.Interface.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public int BuildingNumber { get; set; }

        public int RoomNumber { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual IEnumerable<Class> Classes { get; set; }
    }
}
