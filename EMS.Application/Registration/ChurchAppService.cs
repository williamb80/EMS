using EMS.Application.Model.Interface;
using EMS.Domain.Entity;
using EMS.Domain.Operation.Registration;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System.Transactions;

namespace EMS.Application.Model
{
    public class ChurchAppService : BaseEntityAppService<Church, IChurchService>, IChurchAppService
    {
        public override ValidationResult Save(Church entity)
        {
            using (var ts = new TransactionScope())
            {
                ValidationResult.Add(ContainerFactory.Get<IChurchService>().Save(entity));

                if(ValidationResult.IsValid)
                    ts.Complete();
            }

            return ValidationResult;
        }

        public override ValidationResult Delete(Church entity)
        {
            using (var ts = new TransactionScope())
            {
                ValidationResult.Add(ContainerFactory.Get<IChurchService>().Delete(entity));

                if (ValidationResult.IsValid)
                    ts.Complete();
            }

            return ValidationResult;
        }
    }
}