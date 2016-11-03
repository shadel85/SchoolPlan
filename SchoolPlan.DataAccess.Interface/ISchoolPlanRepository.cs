using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolPlan.DataAccess.Interface
{
    public interface ISchoolPlanRepository<T>  where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        T GetById(int id);

        void Add(T entity);
        void Delete(T entity);
    }
}
