using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Settings
{
    public class Identification: BaseEntity
    {
        public string idenDescription { get; set; }
        public int catId { get; set; }

        public virtual Category category { get; set; }
    }
}
