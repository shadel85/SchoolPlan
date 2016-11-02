using SchoolPlan.Data.Entities;
using SchoolPlan.DataAccess.Interface;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentRepository : SchoolPlanRepository<Student>
    {
        public StudentRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
