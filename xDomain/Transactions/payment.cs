using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;
using xDomain.Clients;
using xDomain.Settings;

namespace xDomain.Transactions
{
    public class payment : BaseEntity
    {
        public int transId { get; set; }
        public DateTime paymentDate { get; set; }
        public string remarks { get; set; }
        public int? clientId { get; set; }
        public int? agentId { get; set; }


        public virtual clientsModel? client { get; set; }
        public virtual AgentDetail? agent { get; set; }
        public virtual ICollection<paymentLines> Lines { get; set; }
    }
}
