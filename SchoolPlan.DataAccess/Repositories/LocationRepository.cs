using SchoolPlan.DataAccess.Interface;
using Location = SchoolPlan.Data.Entities.Location;

namespace SchoolPlan.DataAccess.Repositories
{
    public class LocationRepository : SchoolPlanRepository<Location>
    {
        public LocationRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
