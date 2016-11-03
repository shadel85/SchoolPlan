using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using Ninject;
using Ninject.Modules;

namespace SchoolPlan.IoC
{
    public class AutoMapperModule : NinjectModule
    {
        /// <summary>
        /// Load bindings
        /// </summary>
        public override void Load()
        {
            Bind<ITypeMapFactory>().To<TypeMapFactory>();
            Bind<Configuration>().ToConstant(new Configuration(Kernel.Get<ITypeMapFactory>(), MapperRegistry.Mappers))).InSingletonScope();
            Bind<IConfiguration>().ToMethod(c => c.Kernel.Get<Configuration>());
            Bind<IConfigurationProvider>().ToMethod(c => c.Kernel.Get<Configuration>());
            Bind<IMappingEngine>().To<MappingEngine>();

            Bind<ITypeMapFactory>().To<TypeMapFactory>();
            foreach (var mapper in MapperRegistry.Mappers)
                Bind<IObjectMapper>().ToConstant(mapper);
            Bind<Configuration>().ToSelf().InSingletonScope()
                .WithConstructorArgument("mappers",
                    ctx => ctx.Kernel.GetAll<IObjectMapper>());
            Bind<IConfiguration>().ToMethod(ctx => ctx.Kernel.Get<Configuration>());
            Bind<IConfigurationProvider>().ToMethod(ctx =>
                ctx.Kernel.Get<Configuration>());
            Bind<IMappingEngine>().To<MappingEngine>();
        }
    }
}
