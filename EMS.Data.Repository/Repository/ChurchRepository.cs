using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common.Repository;
using System.Collections.Generic;
using System.Linq;

namespace EMS.Data.Repository.Repository
{
    public class ChurchRepository : BaseRepository<Church>, IChurchRepository
    {
        public Church ObtainByInitials(string initials)
        {
           return Context.Set<Church>().SingleOrDefault(x => x.Name == initials);
        }

        public IEnumerable<Church> ObtainBySearch(string parameterUpper)
        {
            return Context.Set<Church>().Where(x => x.Name.ToString().Contains(parameterUpper) ||
                                                    x.Address.Street.ToUpper().Contains(parameterUpper) ||
                                                    x.Address.State.ToUpper().Contains(parameterUpper) ||
                                                    x.Address.Number.ToUpper().Contains(parameterUpper) ||
                                                    x.Address.City.ToUpper().Contains(parameterUpper) ||
                                                    x.Email.ToUpper().Contains(parameterUpper) ||
                                                    x.FirstPhoneNumber.ToUpper().Contains(parameterUpper) ||
                                                    x.Representatives.Any(y => y.Name.ToUpper().Contains(parameterUpper)) ||
                                                    x.SecondPhoneNumber.Contains(parameterUpper) ||
                                                    x.BirthDate.ToString().Contains(parameterUpper));
        }
    }
}
