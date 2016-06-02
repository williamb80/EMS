using EMS.Framework.Core.Context;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMS.Mvc.Startup))]
namespace EMS.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

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
