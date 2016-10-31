using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Repositories;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentClassRepository : SchoolPlanRepository<StudentClass>, IStudentClassRepository
    {
        public StudentClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
