using EMS.Framework.Core.Common.Validation;
using System.Collections.Generic;

namespace EMS.Framework.Core.Common.Service.Interface
{
    public interface IBaseEntityService<TEntity>
        where TEntity : class
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        ValidationResult Save(TEntity department);
        ValidationResult Delete(TEntity entity);
    }
}
