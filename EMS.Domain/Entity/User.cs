using EMS.Framework.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entity
{
    public class User : BaseEntity
    {
        public override Int32 Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
    }
}
