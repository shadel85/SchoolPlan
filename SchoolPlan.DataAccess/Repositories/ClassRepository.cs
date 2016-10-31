using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Repositories;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class ClassRepository : SchoolPlanRepository<Class>, IClassRepository
    {
        public ClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
