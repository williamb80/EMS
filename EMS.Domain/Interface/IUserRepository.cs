using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User ObtainByEmail(string email);
    }
}
