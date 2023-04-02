using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xDomain._91128.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table & Column Mappings
            builder.ToTable("User");
            builder.Property(f => f.firstNm)
                   .HasMaxLength(40).IsRequired();
            builder.Property(f => f.middleNm)
                   .HasMaxLength(40).IsRequired();
            builder.Property(f => f.lastNm)
                   .HasMaxLength(40).IsRequired();
            builder.Property(f => f.addressTx).HasColumnType("nvarchar(max)");
            builder.Property(f => f.contactTx)
                  .HasMaxLength(13);
            /*System Security*/
            builder.Property(f => f.usernameTx)
                 .HasMaxLength(50).IsRequired();
            builder.Property(f => f.passwordTx)
                 .HasMaxLength(50).IsRequired();
            builder.Property(f => f.emailTx)
                 .HasMaxLength(50).IsRequired();
            builder.Property(f => f.employeeNo)
                 .HasMaxLength(20).IsRequired();
            /*End Security*/
            builder.Property(f => f.created_dt)
                   .HasDefaultValueSql("getdate()");
            builder.Property(f => f.updated_dt)
                   .HasDefaultValueSql("getdate()");
            builder.Property(f => f.isActive_yn)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            //Seeder
            builder.HasData(
                            new User
                            {
                                id = 1,
                                firstNm = "Admin",
                                middleNm = "Admin",
                                lastNm = "Admin",
                                addressTx = "address",
                                contactTx = "contact",
                                usernameTx = "Admin",
                                passwordTx = "p@ssw0rd",
                                emailTx = "dummy.erick@gmail.com",
                                employeeNo = "A2023",
                                created_dt = DateTime.Now,
                                updated_dt = DateTime.Now,
                                isActive_yn = true
                            }
                        );
        }
    }
}
