using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xDomain.Settings;

namespace xDomain.Mapping
{
    public class TransferTypeMapping : IEntityTypeConfiguration<TransferType>
    {
        public void Configure(EntityTypeBuilder<TransferType> builder)
        {
            builder.ToTable("TransferType");

            builder.Property(f => f.transTypeDescription)
               .HasColumnType("nvarchar(max)");
        }
    }
}
