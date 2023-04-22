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
    public class paymentLineMapping : IEntityTypeConfiguration<paymentLines>
    {
        public void Configure(EntityTypeBuilder<paymentLines> builder)
        {
            builder.ToTable("PaymentLine");

            builder.Property(f => f.paymentType)
                .HasMaxLength(100).IsRequired();
            builder.Property(f => f.amount)
              .HasColumnType("decimal(18,2)").HasDefaultValue(0);

            builder.HasOne<payment>(f => f.Payment)
                .WithMany(f => f.Lines)
                .HasForeignKey(f => f.transId);
        }
    }
}
