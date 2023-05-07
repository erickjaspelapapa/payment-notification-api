using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xData.Objects.Setting;
using xDomain._91128;

namespace xData.Objects.Transaction
{
    public class transactionObj : BaseEntity
    {
        public DateTime transDate { get; set; }
        public decimal amount { get; set; }
        public int? catId { get; set; }
        public int? identId { get; set; }
        public string transDescription { get; set; }
        public string remarks { get; set; }
    }
}
