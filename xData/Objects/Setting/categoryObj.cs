using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;
using xDomain.Settings;

namespace xData.Objects.Setting
{
    public class categoryObj : BaseEntity
    {
        public string catDescription { get; set; }
        public  ICollection<identificationObj> identifications { get; set; }
    }
}
