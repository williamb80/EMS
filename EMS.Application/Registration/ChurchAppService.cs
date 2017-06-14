using EMS.Domain.Entity;
using EMS.Domain.Service.Registration;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using System.Collections.Generic;
using EMS.Framework.Core.Context;

namespace EMS.Application.Registration
{
    public class ChurchAppService : BaseEntityAppService<Church, IChurchRepository>, IChurchAppService
    {
        public IEnumerable<Church> ObtainBySearch(string parameterUpper)
        {
            return ContainerFactory.Get<IChurchRepository>().ObtainBySearch(parameterUpper);
        }

        public override ValidationResult Save(Church entity)
        {
            using (var uow = ContainerFactory.Get<IUnityOfWork>())
            {
                uow.BeginTransaction();

                ValidationResult.Add(ContainerFactory.Get<IChurchCRUDService>().Save(entity));

                if (ValidationResult.IsValid)
                    uow.Commit();
            }

            return ValidationResult;
        }

        public override ValidationResult Delete(Church entity)
        {
            using (var uow = ContainerFactory.Get<IUnityOfWork>())
            {
                uow.BeginTransaction();

                ValidationResult.Add(ContainerFactory.Get<IChurchCRUDService>().Delete(entity));

                if (ValidationResult.IsValid)
                    uow.Commit();
            }

            return ValidationResult;
        }
    }
}