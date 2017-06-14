
using System.Data.Entity;

namespace EMS.Framework.Core.Context
{
    public interface IDbContext
    {
        int SaveChanges();
        void Dispose();
        int? CurrentUserId { get; }
        DbContext GetInstance();
    }
}
