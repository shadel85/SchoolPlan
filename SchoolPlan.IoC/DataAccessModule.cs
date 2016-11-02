using Ninject.Modules;
using SchoolPlan.DataAccess.Interface;
using SchoolPlan.DataAccess;
using SchoolPlan.Data;
using SchoolPlan.DataAccess.Interface.Models;
using SchoolPlan.DataAccess.Repositories;

namespace SchoolPlan.IoC
{
    public class DataAccessModule : NinjectModule
    {
        /// <summary>
        /// Load bindings
        /// </summary>
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope().WithConstructorArgument("context", new SchoolPlanContext());

            Bind<ISchoolPlanRepository<Class>>().To<ClassRepository>().InSingletonScope();
            Bind<ISchoolPlanRepository<Location>>().To<LocationRepository>().InSingletonScope();
            Bind<ISchoolPlanRepository<Student>>().To<StudentRepository>().InSingletonScope();
            Bind<ISchoolPlanRepository<StudentClass>>().To<StudentClassRepository>().InSingletonScope();
            Bind<ISchoolPlanRepository<Teacher>>().To<TeacherRepository>().InSingletonScope();
        }
    }
}
