using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xDomain._91128;

namespace xDomain.Mapping
{
    public class AccessLevelMapping : IEntityTypeConfiguration<AccessLevel>
    {
        public void Configure(EntityTypeBuilder<AccessLevel> builder)
        {
            builder.ToTable("AccessLevel");


            builder.Property(f => f.formTypeNo)
               .HasColumnType("int");
            builder.Property(f => f.accessTypeNo)
               .HasColumnType("int");

            builder.Property(f => f.created_dt)
                  .HasDefaultValueSql("getdate()");
            builder.Property(f => f.updated_dt)
                   .HasDefaultValueSql("getdate()");

            builder.HasOne<User>(u => u.Users)
                .WithMany(w => w.AccessLevels)
                .HasForeignKey(f => f.userRef)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);
        }
    }
}
