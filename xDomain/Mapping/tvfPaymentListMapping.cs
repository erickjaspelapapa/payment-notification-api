using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xData.Objects.Transaction;

namespace xDomain.Mapping
{
    public class tvfPaymentListMapping : IEntityTypeConfiguration<tvfPaymentList>
    {
        public void Configure(EntityTypeBuilder<tvfPaymentList> builder)
        {
            //Table & Column Mappings
            builder.ToView("tvfPaymentList");
        }
    }
}
