using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentClassRepository : SchoolPlanRepository<StudentClass>
    {
        public StudentClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
