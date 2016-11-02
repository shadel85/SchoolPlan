using Ninject.Modules;
using SchoolPlan.Services.Interface;
using SchoolPlan.Services;

namespace SchoolPlan.IoC
{
    public class ServiceModule : NinjectModule
    {
        /// <summary>
        /// Load bindings
        /// </summary>
        public override void Load()
        {
            Bind<IClassService>().To<ClassService>().InSingletonScope();
        }
    }
}
