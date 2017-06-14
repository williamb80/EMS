
using System.Data.Entity;

namespace EMS.Framework.Core.Context
{
    public interface IContextManager
    {
        DbContext GetContext();
        void Finish();
    }
}
