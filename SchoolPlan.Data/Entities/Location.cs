using System;
using System.Collections.Generic;

namespace SchoolPlan.Data.Entities
{
    public class Location
    {
        public Location()
        {
            Classes = new List<Class>();
        }

        public int Id { get; set; }

        public int BuildingNumber { get; set; }

        public int RoomNumber { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
