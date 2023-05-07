using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using xData.Objects.Client;
using xData.Objects.Setting;
using xData.Objects.Transaction;
using xDomain.Clients;
using xDomain.Settings;
using xDomain.Transactions;

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
            CreateMap<paymentObj, payment> ();
            CreateMap<paymentLineObj, paymentLines> ();
            CreateMap<categoryObj, Category> ();
            CreateMap<identificationObj,Identification> ();
            CreateMap<transactionObj,transaction> ();

            CreateMap<transaction, transactionListObj>();
            CreateMap<Identification, identificationObj> ();
            CreateMap<Category, transCategoryObj>();
        }
    }
}
    