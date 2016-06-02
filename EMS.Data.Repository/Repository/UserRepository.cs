using EMS.Domain.Entity;
using EMS.Domain.Interface;
using EMS.Framework.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
