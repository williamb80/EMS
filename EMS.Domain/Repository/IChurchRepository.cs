using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Repository;
using System.Collections.Generic;
namespace EMS.Domain.Repository
{
    public interface IChurchRepository : IBaseRepository<Church>
    {
        IEnumerable<Church> ObtainBySearch(string parameterUpper);
    }
}
