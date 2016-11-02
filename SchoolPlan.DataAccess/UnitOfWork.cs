using System.Collections.Generic;
using Ninject;
using Ninject.Parameters;
using SchoolPlan.Data;
using SchoolPlan.DataAccess.Interface;
using System.Linq;
using System.Reflection;
using SchoolPlan.DataAccess.Interface.Models;
using SchoolPlan.DataAccess.Repositories;

namespace SchoolPlan.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolPlanContext _context;

        public UnitOfWork() : this(new SchoolPlanContext()) { }

        public UnitOfWork(SchoolPlanContext context)
        {
            _context = context;
        }

        public SchoolPlanContext Context => _context;
        private ISchoolPlanRepository<Class> _classRepository;
      
        public ISchoolPlanRepository<Class> ClassRepository => _classRepository ?? (_classRepository = new ClassRepository(this));

        //public T GetRepository<T>()
        //{
        //    using (var kernel = new StandardKernel())
        //    {
        //        kernel.Load(Assembly.GetExecutingAssembly());
        //        var result = kernel.Get<T>(new ConstructorArgument("unitOfWWork", this));

        //        if (result != null)
        //        {
        //            return result;
        //        }
        //    }
        //    //TODO
        //    // Optional: return an error instead of a null?
        //    //var msg = typeof (T).FullName + " doesn't implement the IBlogModule.";
        //    //throw new Exception(msg);
        //    return default(T);
        //}

        public void Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
