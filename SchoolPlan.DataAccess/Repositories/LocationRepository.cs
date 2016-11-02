using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class LocationRepository : SchoolPlanRepository<Location>
    {
        public LocationRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
