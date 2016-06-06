using EMS.Domain.Entity;
using EMS.Domain.Interface;
using EMS.Framework.Core.Common;
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
