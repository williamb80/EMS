using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Framework.Core.Common.Interface;
using EMS.Domain.Entity;

namespace EMS.Application.Interface
{
    public interface IUserAppService : IBaseAppService<User>
    {
    }
}
