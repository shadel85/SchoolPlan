using System.Web.Http;
using AutoMapper;
using SchoolPlan.Services.Interface.Mapping;
using SchoolPlan.DataAccess.Interface.Mapping;
using SchoolPlan.Web.Mapping;
using Bootstrap;
using Bootstrap.AutoMapper;


namespace SchoolPlan.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.Configure();
            Mapper.AssertConfigurationIsValid();
            // Bootstrapper.With.AutoMapper().Start();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
