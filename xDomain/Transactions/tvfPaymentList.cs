using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xData.Objects.Transaction
{
    public class tvfPaymentList : BaseEntity
    {
        public int clientId { get; set; }
        public string clientNumber { get; set; }
        public string clientName { get; set; }
        public int transId { get; set; }
        public decimal? Downpayment { get; set; }
        public decimal? Reservation { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? AgentCommission { get; set; }
        public decimal? NotarialFee { get; set; }
        public decimal? Promo { get; set; }
        public decimal? TransferFee { get; set; }
        public DateTime paymentDate { get; set; }
        public string remarks { get; set; }
        public int agentId { get; set; }

    }
}
