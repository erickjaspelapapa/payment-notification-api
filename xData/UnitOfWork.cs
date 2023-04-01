using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using xData.Data;
using xRepository._91128;

namespace xData._91128
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity
        {
            return new Repository<TEntity>(_context);
        }

        protected Dictionary<string, dynamic> Repositories;
        private readonly paymentContext _context;

        public UnitOfWork(paymentContext context)
        {
            this._context = context;                                
            Repositories = new Dictionary<string, dynamic>();
        }
        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
