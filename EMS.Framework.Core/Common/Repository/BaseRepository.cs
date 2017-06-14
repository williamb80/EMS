using EMS.Framework.Core.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EMS.Framework.Core.Common.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        private DbContext _context;
        private readonly ContextManager _contextManager = new ContextManager();
        protected readonly IDbSet<TEntity> _dbSet;

        public DbContext Context
        {
            get
            {
                if (_context == null)
                {
                    try
                    {
                        _context = _contextManager.GetContext();
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }

                _context.Configuration.LazyLoadingEnabled = true;

                return _context;
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

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public void Save(TEntity entity)
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
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
        }

        
    }
}
