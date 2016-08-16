using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common;
using EMS.Framework.Core.Common.Repository;
using System.Linq;

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
