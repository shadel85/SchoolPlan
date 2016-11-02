using SchoolPlan.Data;
using System;
using SchoolPlan.Data.Entities;

namespace SchoolPlan.DataAccess.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        SchoolPlanContext Context { get; }

        ISchoolPlanRepository<Class> ClassRepository { get; }
        ISchoolPlanRepository<Student> StudentRepository { get; }
        ISchoolPlanRepository<Location> LocationRepository { get; }
        ISchoolPlanRepository<Teacher> TeacherRepository { get; }
        ISchoolPlanRepository<StudentClass> StudentClassRepository { get; }

        //T GetRepository<T>();
        void Commit();
        void Rollback();
    }
}
