using EMS.Application;
using EMS.Application.Interface;
using EMS.Data.Repository.Repository;
using EMS.Domain.Interface;
using EMS.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.CrossCutting.DependencyInjection
{
    public class RegisterDependencyInjection : BaseRegisterDependencyInjection
    {
        public override void Configure()
        {
            #region Application

            ContainerFactory.Bind<IUserAppService, UserAppService>();
            ContainerFactory.Bind<IChurchAppService, ChurchAppService>();

            #endregion


            #region Repository

            ContainerFactory.Bind<IUserRepository, UserRepository>();
            ContainerFactory.Bind<IChurchRepository, ChurchRepository>();

            #endregion
        }
    }
}
