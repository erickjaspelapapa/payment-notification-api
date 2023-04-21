using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.DependencyInjection;
using xData._91128;
using xData.Data;
using xDomain._91128;
using xRepository._91128;

namespace x91128x.Utility
{
    public static class EfExtentionService
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, string conStr) {
            services.AddDbContext<paymentContext>(opt => opt.UseLazyLoadingProxies().UseSqlServer(conStr, x=> x.MigrationsAssembly("xData")));
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
