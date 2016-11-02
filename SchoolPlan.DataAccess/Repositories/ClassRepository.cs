using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class ClassRepository : SchoolPlanRepository<Data.Entities.Class>
    {
        public ClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
