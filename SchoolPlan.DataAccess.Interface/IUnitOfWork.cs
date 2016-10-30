using SchoolPlan.Data;
using System;

namespace SchoolPlan.DataAccess.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        SchoolPlanContext Context { get; }
        T GetRepository<T>();
        void Commit();
        void Rollback();
    }
}
