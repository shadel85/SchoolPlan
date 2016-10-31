using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;
using SchoolPlan.DataAccess.Interface.Repositories;

namespace SchoolPlan.DataAccess.Repositories
{
    public class LocationRepository : SchoolPlanRepository<Location>, ILocationRepository
    {
        public LocationRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
