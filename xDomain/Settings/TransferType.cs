using xDomain.Clients;

namespace xDomain.Settings
{
    public class TransferType
    {
        public int id { get; set; }
        public string transTypeDescription { get; set; }
        public virtual clientsModel Client { get; set; }
    }
}
