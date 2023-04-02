using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using xData.Objects.Client;
using xDomain.Clients;
using xDomain.Settings;

namespace xDomain._91128
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            CreateMap<agentDetailObj, AgentDetail> ();
            CreateMap<transTypeObj, TransferType> ();
            CreateMap<prjGrpObj, ProjectGroup> ();
            CreateMap<clientObj, clientsModel> ();
        }
    }
}
    