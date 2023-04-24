using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain.Transactions;

namespace xDomain.Mapping
{
    public class tvfPaymentRecordsMapping : IEntityTypeConfiguration<tvfPaymentRecords>
    {
        public void Configure(EntityTypeBuilder<tvfPaymentRecords> builder)
        {
            //Table & Column Mappings
            builder.ToView("tvfPaymentRecords");
        }
    }
}
