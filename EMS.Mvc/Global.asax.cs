using EMS.CrossCutting.DependencyInjection;
using EMS.Framework.Core.Context;
using EMS.Framework.Core.DependencyInjection;
using EMS.Mvc.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EMS.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); 
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();

            ContainerSetup containerSetup = new RegisterDependencyInjection();
            containerSetup.Configure();

            ContextManager.Context = new ContextVO 
            {
                ConnectionStringEnvironment = "DBEMS",
                DataSource = "",
                UserName = "ADMIN",
                Name = "ADMIN",
                Password = "ADMIN"
            };
        }
    }
}
