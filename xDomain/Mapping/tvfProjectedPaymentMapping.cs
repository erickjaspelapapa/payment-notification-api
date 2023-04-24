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
    public class tvfProjectedPaymentMapping : IEntityTypeConfiguration<tvfProjectedPayment>
    {
        public void Configure(EntityTypeBuilder<tvfProjectedPayment> builder)
        {
            builder.ToView("tvfProjectedPayment");
        }
    }
}
