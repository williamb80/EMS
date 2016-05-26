using EMS.Application.Interface;
using EMS.Domain.Entity;
using EMS.Domain.Interface;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EMS.Application
{
    public class UserAppService : BaseAppService<User, IUserRepository>, IUserAppService
    {
        public override void Save(User entity)
        {
            using (var ts = new TransactionScope())
            {
                ContainerFactory.Get<IUserRepository>().SaveOrUpdate(entity);
                ts.Complete();
            }
        }

        public override void Delete(User entity)
        {
            using (var ts = new TransactionScope())
            {
                ContainerFactory.Get<IUserRepository>().Delete(entity);
                ts.Complete();
            }
        }
    }
}
