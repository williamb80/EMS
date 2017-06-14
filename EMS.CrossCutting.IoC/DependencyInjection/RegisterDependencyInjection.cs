using EMS.Application.Registration;
using EMS.Data.Repository.Repository;
using EMS.Domain.Repository;
using EMS.Domain.Service.Registration;
using EMS.Framework.Core.DependencyInjection;
using EMS.Framework.Core.Context;
using EMS.Data.Context;

namespace EMS.CrossCutting.DependencyInjection
{
    public class RegisterDependencyInjection : ContainerSetup
    {        
        public override void ConfigureBinds()
        {

            ContainerFactory.Bind<IDbContext, EMSContext>();

            #region Application

            ContainerFactory.Bind<IUserAppService, UserAppService>();
            ContainerFactory.Bind<IChurchAppService, ChurchAppService>();
            ContainerFactory.Bind<IRepresentativeAppService, RepresentativeAppService>();

            #endregion

            #region Service
            ContainerFactory.Bind<IUserCRUDService, UserCRUDService>();
            ContainerFactory.Bind<IChurchCRUDService, ChurchCRUDService>();
            ContainerFactory.Bind<IRepresentativeCRUDService, RepresentativeCRUDService>();
            #endregion

            #region Repository

            ContainerFactory.Bind<IUserRepository, UserRepository>();
            ContainerFactory.Bind<IChurchRepository, ChurchRepository>();
            ContainerFactory.Bind<IRepresentativeRepository, RepresentativeRepository>();

            #endregion
        }
    }
}
