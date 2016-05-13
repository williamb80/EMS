using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Common.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        IList<TEntity> GetAll();
        void Insert(int id);
        void Salvar(TEntity entity);
        void Delete(TEntity entity);
    }
}
