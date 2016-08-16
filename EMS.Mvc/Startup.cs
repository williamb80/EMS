using EMS.Framework.Core.Context;
using EMS.Framework.Core.DependencyInjection;
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

        }
    }
}
