using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xDomain.Settings;

namespace xDomain.Mapping
{
    public class IdentitficationMapping : IEntityTypeConfiguration<Identification>
    {
        public void Configure(EntityTypeBuilder<Identification> builder)
        {
            builder.ToTable("Identification");

            builder.Property(x => x.idenDescription)
                .HasColumnType("nvarchar(250)");

            builder.HasOne(x => x.category)
                .WithMany(x => x.identifications)
                .HasForeignKey(f => f.catId);
        }
    }
}
