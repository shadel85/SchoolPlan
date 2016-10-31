using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;
using SchoolPlan.DataAccess.Interface.Repositories;

namespace SchoolPlan.DataAccess.Repositories
{
    public class TeacherRepository : SchoolPlanRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
