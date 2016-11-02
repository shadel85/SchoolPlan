using SchoolPlan.DataAccess.Interface;
using Teacher = SchoolPlan.Data.Entities.Teacher;

namespace SchoolPlan.DataAccess.Repositories
{
    public class TeacherRepository : SchoolPlanRepository<Teacher>
    {
        public TeacherRepository(IUnitOfWork unitOfWWork) : base(unitOfWWork) { }
    }
}
