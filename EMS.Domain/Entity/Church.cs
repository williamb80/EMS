using EMS.Framework.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entity
{
    public class Church : BaseEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
