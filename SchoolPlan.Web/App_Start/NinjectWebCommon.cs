using System;
using System.Reflection;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.WebApi;
using SchoolPlan.Services.Interface.Models;
using SchoolPlan.Web;
using StudentClass = SchoolPlan.Web.Models.StudentClass;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace SchoolPlan.Web
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                //kernel.Bind<IMappingEnging>().ToMethod(ctx => Mapper.Engine);
                //kernel.Bind<IConfigurationProvider>().ToMethod(x => Mapper.Engine.ConfigurationProvider);
                var config = AutoMapperConfig.Configure();

                kernel.Bind<MapperConfiguration>().ToMethod(c => config);

                kernel.Bind<IMapper>().ToMethod(m => config.CreateMapper());

                //var source = new Source();
                //var dest = mapper.Map<Source, Dest>(source);


                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load(Assembly.GetExecutingAssembly(),
               Assembly.Load("SchoolPlan.IoC"));
        }
    }
}
