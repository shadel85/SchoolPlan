using AutoMapper;
using SchoolPlan.DataAccess.Interface.Mapping;
using SchoolPlan.Web.Models;
using SchoolPlan.Services.Interface.Mapping;
using SchoolPlan.Web.Mapping;

namespace SchoolPlan.Web
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<WebProfile>();
                //config.AddProfile<ServiceProfile>();
                //config.AddProfile<DataAccessProfile>();
            });
            //Mapper.Initialize(cfg => cfg.CreateMap<Class, Services.Interface.Models.Class>());
        }
    }
}