using System.Collections.Generic;

namespace EMS.Framework.Core.Common.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        #region ReadOnly

        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();

        #endregion


        #region Transaction

        void Insert(TEntity id);
        void Update(TEntity entity);
        void Save(TEntity entity);
        void Delete(TEntity entity);

        #endregion
    }
}
