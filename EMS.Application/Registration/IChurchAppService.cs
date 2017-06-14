using EMS.Domain.Entity;
using EMS.Framework.Core.Common.App;
using System.Collections.Generic;

namespace EMS.Application.Registration
{
    public interface IChurchAppService : IBaseAppService<Church>
    {
        IEnumerable<Church> ObtainBySearch(string parameterUpper);
    }
}
