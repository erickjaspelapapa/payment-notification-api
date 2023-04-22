using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xData.Objects.Transaction
{
    public class paymentObj : BaseEntity
    {
        public int transId { get; set; }
        public DateTime paymentDate { get; set; }
        public string remarks { get; set; }
        public int? clientId { get; set; }
        public int? agentId { get; set; }
        public ICollection<paymentLineObj> Lines { get; set; }
    }
}
