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
            context.Students.AddOrUpdate(
              new Student { FirstName = "David", LastName = "Jackson", Age = 19 },
              new Student { FirstName = "Peter", LastName = "Parker", Age = 19 }
            );
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
