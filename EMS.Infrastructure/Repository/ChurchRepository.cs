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
    public class ChurchRepository : BaseRepository<Church>, IChurchRepository
    {
        public Church ObtainByInitials(string initials)
        {
           return Context.Set<Church>().SingleOrDefault(x => x.Name == initials);
        }
    }
}
