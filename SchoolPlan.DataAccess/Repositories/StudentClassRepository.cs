using SchoolPlan.Data.Entities;
using SchoolPlan.DataAccess.Interface;
using Student = SchoolPlan.Data.Entities.Student;

namespace SchoolPlan.DataAccess.Repositories
{
    public class StudentClassRepository : SchoolPlanRepository<StudentClass>
    {
        public StudentClassRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
