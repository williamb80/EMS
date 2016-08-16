using EMS.Application.Interface;
using EMS.Domain.Entity;
using EMS.Domain.Service.Model;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System.Transactions;

namespace EMS.Application
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