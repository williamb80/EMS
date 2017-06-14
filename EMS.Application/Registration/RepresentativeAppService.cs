using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common.App;
using EMS.Framework.Core.Common.Validation;
using System;

namespace EMS.Application.Registration
{
    public class RepresentativeAppService : BaseEntityAppService<Representative, IRepresentativeRepository>, IRepresentativeAppService
    {
        public override ValidationResult Delete(Representative entity)
        {
            throw new NotImplementedException();
        }

        public override ValidationResult Save(Representative entity)
        {
            throw new NotImplementedException();
        }
    }
}
