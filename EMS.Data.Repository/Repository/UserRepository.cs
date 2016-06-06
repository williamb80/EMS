using EMS.Domain.Entity;
using EMS.Domain.Interface;
using EMS.Framework.Core.Common;
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
