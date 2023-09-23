using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Transactions
{
    public class tvfDailySummary: BaseEntity
    {
        public decimal? TotalClientPayment { get; set; }
        public decimal? InitialCapitalInvestment { get; set; }
        public decimal? OtherCashoutPayments { get; set; }
        public decimal? OtherCashinPayments { get; set; }
        public decimal? AgentsCommission { get; set; }
        public decimal? NotarialFee { get; set; }
        public decimal? ProcessingFee { get; set; }
        public decimal? PreviousExpenses { get; set; }
        public decimal? PendingPaymentCasaPrimoDTRCashIn { get; set; }
        public decimal? PendingPaymentCasaPrimoDTRCashOut { get; set; }
        public decimal? PendingPaymentCasaPrimoPassbookCashIn { get; set; }
        public decimal? PendingPaymentCasaPrimoPassbookCashOut { get; set; }
        public decimal? FixedExpense { get; set; }
        public decimal? ControlledExpense { get; set; }
        public decimal? PettyCashPettyCashIn { get; set; }

    }
}
