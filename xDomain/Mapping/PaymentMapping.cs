using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xDomain.Transactions;

namespace xDomain.Mapping
{
    public class PaymentMapping : IEntityTypeConfiguration<payment>
    {
        public void Configure(EntityTypeBuilder<payment> builder)
        {
            builder.ToTable("Payment");

            builder.Property(f => f.transId)
                .HasColumnType("int").IsRequired();
            builder.Property(f => f.paymentDate)
                .HasDefaultValueSql("getdate()");
            builder.Property(f => f.remarks)
                .HasColumnType("nvarchar(max)");
           
            builder.HasOne(f => f.agent)
                .WithOne()
                .HasForeignKey<payment>(f => f.agentId);

            builder.HasOne(f => f.client)
                .WithOne()
                .HasForeignKey<payment>(f => f.clientId);
        }
    }
}
