using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;
using xDomain.Settings;

namespace xDomain.Transactions
{
    public class transaction : BaseEntity
    {
        public DateTime transDate { get; set; }
        public decimal amount { get; set; }
        public int? catId { get; set; }
        public int? identId { get; set; }
        public string transDescription { get; set; }
        public string remarks { get; set; }

        public virtual Category category { get; set; }
        public virtual Identification identification{ get; set; }
    }
}
