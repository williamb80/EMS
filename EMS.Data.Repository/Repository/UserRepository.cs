using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Repository;
using System.Linq;

namespace EMS.Data.Repository.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public User ObtainByEmail(string email)
        {
           return Context.Set<User>().FirstOrDefault(user => user.Email == email);
        }
    }
}
