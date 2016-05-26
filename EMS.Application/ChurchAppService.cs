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
    public class ChurchAppService : BaseAppService<Church, IChurchRepository>, IChurchAppService
    {
        public override void Save(Church entity)
        {
            using (var ts = new TransactionScope())
            {
                ContainerFactory.Get<IChurchRepository>().SaveOrUpdate(entity);
                ts.Complete();
            }
        }

        public override void Delete(Church entity)
        {
            using (var ts = new TransactionScope())
            {
                ContainerFactory.Get<IChurchRepository>().Delete(entity);
                ts.Complete();
            }
        }
    }
}