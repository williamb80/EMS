using System;

namespace EMS.Framework.Core.Context
{
    public interface IUnityOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
    }
}
