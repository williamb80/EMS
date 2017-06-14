﻿
using EMS.CrossCutting.DependencyInjection;
using EMS.Framework.Core.DependencyInjection;
using EMS.Mvc.AutoMapper;
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

            AutoMapperConfig.RegisterMappings();

            ContainerSetup containerSetup = new RegisterDependencyInjection();
            containerSetup.Configure();
        }
    }
}
