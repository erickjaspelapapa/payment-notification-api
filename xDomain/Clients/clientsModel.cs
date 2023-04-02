using xDomain.Settings;

namespace xDomain.Clients
{
    public  class clientsModel
    {
        public int id { get; set; }
        public string clientId { get; set; }
        public string clientName { get; set; }
        public string clientContactNumber { get; set; }
        public string bldgBlock { get; set; }
        public string bldgLot { get; set; }
        public double totalContractPrice { get; set; }
        public DateTime dateStartMonthlyPay { get; set; }
        public double transferFee { get; set; }
        public int transTypeId { get; set; }
        public int agentId { get; set; }
        public int projGrpId { get; set; }

        public virtual AgentDetail Agent{ get; set; }
        public virtual TransferType TransType { get; set; }
        public virtual ProjectGroup ProjGroup { get; set; }
    }
}
