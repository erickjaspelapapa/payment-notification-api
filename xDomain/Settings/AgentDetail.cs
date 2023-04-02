using xDomain.Clients;

namespace xDomain.Settings
{
    public class AgentDetail
    {
        public int id { get; set; }
        public string agentFirstName { get; set; }
        public string agentLastName { get; set; }

        public virtual clientsModel Client { get; set; }
    }
}
