using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Bootstrap;
using Bootstrap.AutoMapper;

namespace SchoolPlan.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Bootstrapper.With.AutoMapper().Start();
        }
    }
}
