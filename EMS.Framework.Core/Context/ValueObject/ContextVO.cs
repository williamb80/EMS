using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Framework.Core.Context
{
    public class ContextVO
    {
        public String Name { get; set; }
        public String DataSource { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String ConnectionString { get; set; }
    }
}
