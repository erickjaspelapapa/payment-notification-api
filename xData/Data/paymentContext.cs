using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using xDomain._91128;
using xDomain._91128.Mapping;

namespace xData.Data
{
    public class paymentContext : DbContext
    {
        public paymentContext(DbContextOptions<paymentContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMap).Assembly);

        }
    }
}
