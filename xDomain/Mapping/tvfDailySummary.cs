using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xData.Objects.Transaction;
using xDomain.Transactions;

namespace xDomain.Mapping
{
    public class tvfDailySummaryMapping : IEntityTypeConfiguration<tvfDailySummary>
    {
        public void Configure(EntityTypeBuilder<tvfDailySummary> builder)
        {
            //Table & Column Mappings
            builder.ToView("tvfDailySummary");
        }
    }
}
