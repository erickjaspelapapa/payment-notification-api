using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Settings
{
    public class Category : BaseEntity
    {
        public string catDescription { get; set; }
        public virtual ICollection<Identification> identifications { get; set; }
    }
}
