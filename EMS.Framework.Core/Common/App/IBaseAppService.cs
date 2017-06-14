using EMS.Framework.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.App
{
    public interface IBaseAppService<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        ValidationResult Save(TEntity entity);
        ValidationResult Delete(TEntity entity);
    }
}
