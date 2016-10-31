using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Repositories;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentRepository : SchoolPlanRepository<Student>, IStudentRepository
    {
        public StudentRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
