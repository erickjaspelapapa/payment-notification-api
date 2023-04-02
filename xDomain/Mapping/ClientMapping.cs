using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xDomain.Clients;

namespace xDomain.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<clientsModel>
    {
        public void Configure(EntityTypeBuilder<clientsModel> builder)
        {
            builder.ToTable("Client");


            builder.Property(f => f.clientId)
                .HasMaxLength(100).IsRequired();
            builder.Property(f => f.clientName)
                .HasColumnType("nvarchar(max)");
            builder.Property(f => f.clientContactNumber)
               .HasMaxLength(40);
            builder.Property(f => f.bldgBlock)
                .HasMaxLength(25);
            builder.Property(f => f.bldgLot)
                .HasMaxLength(25);
            builder.Property(f => f.totalContractPrice)
               .HasColumnType("decimal(18,2)").HasDefaultValue(0);
            builder.Property(f => f.transferFee)
               .HasColumnType("decimal(18,2)").HasDefaultValue(0);

            builder.Property(f => f.dateStartMonthlyPay)
                       .HasDefaultValueSql("getdate()");

            builder.HasOne(f => f.Agent)
                .WithOne()
                .HasForeignKey<clientsModel>(f => f.agentId);

            builder.HasOne(f => f.TransType)
                .WithOne()
                .HasForeignKey<clientsModel>(f => f.transTypeId);

            builder.HasOne(f => f.ProjGroup)
                .WithOne()
                .HasForeignKey<clientsModel>(f => f.projGrpId);
        }
    }
}
