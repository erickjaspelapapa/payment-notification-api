using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xDomain.Settings;

namespace xDomain.Mapping
{
    public class AgentMapping : IEntityTypeConfiguration<AgentDetail>
    {
        public void Configure(EntityTypeBuilder<AgentDetail> builder)
        {
            builder.ToTable("AgentDetail");

            builder.Property(f => f.agentFirstName)
                .HasMaxLength(100);
            builder.Property(f => f.agentLastName)
                .HasMaxLength(100);
        }
    }
}
