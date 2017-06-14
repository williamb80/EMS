using System;
using System.Data.Entity;

namespace EMS.Framework.Core.Context
{

    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly ContextManager _contextManager =
            new ContextManager();

        private readonly DbContext _dbContext;
        private bool _disposed;


        public UnityOfWork()
        {
            _dbContext = _contextManager.GetContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
