using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain._91128
{
    public class AccessLevel : BaseEntity
    {
        public int userRef { get; set; }

        public int formTypeNo { get; set; }
        public int accessTypeNo { get; set; }

        public virtual User? Users { get; set; }
    }
}
