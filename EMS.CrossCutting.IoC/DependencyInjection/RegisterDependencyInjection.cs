using EMS.Application;
using EMS.Application.Interface;
using EMS.Data.Repository.Mapping.Common;
using EMS.Data.Repository.Repository;
using EMS.Domain.Repository;
using EMS.Domain.Service.Model;
using EMS.Framework.Core.DependencyInjection;
using EMS.Framework.Core.DependencyInjection.Interface;

namespace EMS.CrossCutting.DependencyInjection
{
    public class RegisterDependencyInjection : ContainerSetup
    {        
        public override void ConfigureBinds()
        {
            #region Application

            ContainerFactory.Bind<IUserAppService, UserAppService>();
            ContainerFactory.Bind<IChurchAppService, ChurchAppService>();

            #endregion


            #region Service
            ContainerFactory.Bind<IUserService, UserService>();
            ContainerFactory.Bind<IChurchService, ChurchService>();
            #endregion

            #region Repository

            ContainerFactory.Bind<IMappings, Mappings>();
            ContainerFactory.Bind<IUserRepository, UserRepository>();
            ContainerFactory.Bind<IChurchRepository, ChurchRepository>();

            #endregion
        }
    }
}
