using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentRepository : SchoolPlanRepository<Student>
    {
        public StudentRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
