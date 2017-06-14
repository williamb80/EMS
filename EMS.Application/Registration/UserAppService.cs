using EMS.Domain.Entity;
using EMS.Domain.Service.Registration;
using EMS.Framework.Core.Context;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using EMS.Domain.Repository;

namespace EMS.Application.Registration
{
    public class UserAppService : BaseEntityAppService<User, IUserRepository>, IUserAppService
    {
        public override ValidationResult Save(User entity)
        {
            using (var uow = ContainerFactory.Get<IUnityOfWork>())
            {
                uow.BeginTransaction();

                ValidationResult.Add(ContainerFactory.Get<IUserCRUDService>().Save(entity));

                if (ValidationResult.IsValid)
                    uow.Commit();
            }

            return ValidationResult;
        }

        public override ValidationResult Delete(User entity)
        {
            using (var uow = ContainerFactory.Get<IUnityOfWork>())
            {
                uow.BeginTransaction();

                ValidationResult.Add(ContainerFactory.Get<IUserCRUDService>().Delete(entity));

                if (ValidationResult.IsValid)
                    uow.Commit();
            }

            return ValidationResult;
        }
    }
}
