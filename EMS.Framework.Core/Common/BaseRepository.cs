using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using EMS.Framework.Core.Extension;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Framework.Core.Context;

namespace EMS.Framework.Core.Common
{
    public class BaseRepository<TEntity> : IDisposable where TEntity : BaseEntity, new()
    {
        private DbContext _objContext;
        protected readonly IDbSet<TEntity> _dbSet;

        public DbContext Context
        {
            get
            {
                if (_objContext == null)
                    _objContext = new DBContext();

                _objContext.Configuration.LazyLoadingEnabled = true;

                return _objContext;
            }
        }

        public BaseRepository()
        {
            _dbSet = Context.Set<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void SaveOrUpdate(TEntity entity)
        {
            if (entity.Id == default(Int32))
            {
                Insert(entity);
            }
            else
            {
                Update(entity);
            }
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
            SaveChanges();
        }

        public void SaveChanges()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var failure in ex.EntityValidationErrors)
                {

                }
            }

        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }
        #endregion
    }
}
