using xDomain.Clients;

namespace xDomain.Settings
{
    public class ProjectGroup
    {
        public int id { get; set; }
        public string projGrpDescription { get; set; }
        public virtual clientsModel Client { get; set; }
    }
}
