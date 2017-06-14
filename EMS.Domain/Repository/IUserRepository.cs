using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Repository;
namespace EMS.Domain.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User ObtainByEmail(string email);
    }
}
