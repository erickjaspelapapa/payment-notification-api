using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xData.Objects.Setting;

namespace xData.Objects.Transaction
{
    public class transactionListObj: transactionObj
    {
        public transCategoryObj category { get; set; }
        public identificationObj identification{ get; set; }

    }
}
