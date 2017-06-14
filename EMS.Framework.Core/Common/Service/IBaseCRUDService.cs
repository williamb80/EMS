using EMS.Framework.Core.Common.Validation;

namespace EMS.Framework.Core.Common.Service
{
    public interface IBaseCRUDService<TEntity>
        where TEntity : IEntity
    {
        ValidationResult Save(TEntity department);
        ValidationResult Delete(TEntity entity);
    }
}
