using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class TeacherRepository : SchoolPlanRepository<Teacher>
    {
        public TeacherRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
