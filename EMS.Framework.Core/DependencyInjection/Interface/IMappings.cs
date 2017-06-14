using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.DependencyInjection.Interface
{
    public interface IMappings
    {
        DbContext GetInstance();
    }
}
