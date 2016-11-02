using SchoolPlan.Data;
using System;
using SchoolPlan.DataAccess.Interface.Models;

namespace SchoolPlan.DataAccess.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        SchoolPlanContext Context { get; }
        ISchoolPlanRepository<Class> ClassRepository { get; }
        //T GetRepository<T>();
        void Commit();
        void Rollback();
    }
}
