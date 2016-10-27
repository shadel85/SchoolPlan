namespace SchoolPlan.Data.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolPlanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolPlanContext context)
        {
            context.Students.AddOrUpdate(s => s.LastName,
              new Student { FirstName = "David", LastName = "Jackson", Age = 19, CreationDate = DateTime.Now },
              new Student { FirstName = "Peter", LastName = "Parker", Age = 19, CreationDate = DateTime.Now }
            );

            context.Locations.AddOrUpdate(r => new { r.RoomNumber, r.BuildingNumber },
           new Location { BuildingNumber = 5, RoomNumber = 201, CreationDate = DateTime.Now },
           new Location { BuildingNumber = 3, RoomNumber = 134, CreationDate = DateTime.Now }
         );
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
