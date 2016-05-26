using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Common.Interface
{
    public interface IBaseAppService<TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
