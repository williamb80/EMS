using EMS.Application.Registration.Interface;
using EMS.Domain.Entity;
using EMS.Domain.Operation.Registration;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System.Transactions;

namespace EMS.Application.Registration
{
    public class UserAppService : BaseEntityAppService<User, IUserService>, IUserAppService
    {
        public override ValidationResult Save(User entity)
        {
            using (var ts = new TransactionScope())
            {
                ValidationResult.Add(ContainerFactory.Get<IUserService>().Save(entity));

                if (ValidationResult.IsValid)
                    ts.Complete();
            }

            return ValidationResult;
        }

        public override ValidationResult Delete(User entity)
        {
            using (var ts = new TransactionScope())
            {
                ValidationResult.Add(ContainerFactory.Get<IUserService>().Delete(entity));

                if (ValidationResult.IsValid)
                    ts.Complete();
            }

            return ValidationResult;
        }
    }
}
