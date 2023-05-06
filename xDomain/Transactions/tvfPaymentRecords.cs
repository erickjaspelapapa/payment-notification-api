using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;

namespace xDomain.Transactions
{
    public class tvfPaymentRecords : BaseEntity
    {
        public int? id { get; set; }
        public bool? forProcessing { get; set; }
        public string? clientId { get; set; }
        public string? client { get; set; }
        public DateTime? latestPayment { get; set; }
        public DateTime? firstMonthlyPay { get; set; }
        public string? firstMonthlyPayFormatted { get; set; }
        public decimal? totalContractPrice { get; set; }
        public decimal? projectedMonPaymentAmt { get; set; }
        public int? monthsToPay { get; set; }
        public int? monthsPayLeft { get; set; }
        public string? agent { get; set; }
        public decimal? Downpayment { get; set; }
        public decimal? DownpaymentPerc { get; set; }
        public decimal? Reservation { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? AgentCommission { get; set; }
        public decimal? AgentCommsPerc { get; set; }
        public decimal? NotarialFee { get; set; }
        public decimal? Promo { get; set; }
        public decimal? TransferFee { get; set; }
        public decimal? TotalBalance { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? TransferFeePaid { get; set; }
    }
}
