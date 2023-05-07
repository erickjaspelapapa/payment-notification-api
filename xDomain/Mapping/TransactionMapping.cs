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
    internal class TransactionMapping : IEntityTypeConfiguration<transaction>
    {
        public void Configure(EntityTypeBuilder<transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.Property(f => f.amount)
                .HasColumnType("decimal(10,2)")
                .HasDefaultValue(0);

            builder.Property(f => f.transDescription)
                .HasColumnType("nvarchar(max)")
                .IsRequired(false);
            builder.Property(f => f.remarks)
                .HasColumnType("nvarchar(max)")
                .IsRequired(false);
            builder.Property(f => f.transDate)
                .HasDefaultValueSql("getdate()");

            builder.HasOne(f => f.category)
                .WithOne()
                .HasForeignKey<transaction>(f => f.catId)
                .IsRequired(false);


            builder.HasOne(f => f.identification)
                .WithOne()
                .HasForeignKey<transaction>(f => f.identId)
                .IsRequired(false);

        }
    }
}
