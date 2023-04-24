using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Transactions
{
    public class tvfProjectedPayment : BaseEntity
    {
        public string clientId { get; set; }
        public int monthPay { get; set; }
        public int yearPay { get; set; }
        public decimal amount { get; set; }
    }
}
