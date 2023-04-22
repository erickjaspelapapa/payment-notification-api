using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xData.Objects.Transaction
{
    public class paymentLineObj : BaseEntity
    {
        public int transId { get; set; }
        public string paymentType { get; set; }
        public double amount { get; set; }
    }
}
