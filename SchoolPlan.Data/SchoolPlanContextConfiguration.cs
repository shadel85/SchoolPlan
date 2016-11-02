using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlan.Data
{
    public class SchoolPlanContextConfiguration : DbMigrationsConfiguration<SchoolPlanContext>
    {
        public SchoolPlanContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

#if DEBUG
        protected override void Seed(SchoolPlanContext context)
        {
            
        }
#endif
    }
}
