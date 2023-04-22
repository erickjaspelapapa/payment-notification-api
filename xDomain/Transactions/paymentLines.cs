using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Transactions
{
    public  class paymentLines: BaseEntity
    {
        public int transId { get; set; }
        public string paymentType { get; set; }
        public double amount { get; set; }

        public virtual payment Payment { get; set; }
    }
}
