using Microsoft.EntityFrameworkCore;
using xDomain._91128.Mapping;

namespace xData.Data
{
    public class paymentContext : DbContext
    {
        public paymentContext(DbContextOptions<paymentContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMap).Assembly);

        }
    }
}
