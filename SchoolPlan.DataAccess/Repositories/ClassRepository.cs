using SchoolPlan.DataAccess.Interface;

namespace SchoolPlan.DataAccess.Repositories
{
    public class ClassRepository : SchoolPlanRepository<Data.Entities.Class>
    {
        public ClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
