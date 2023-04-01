using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace xRepository._91128
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity;
        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);
        Task Commit();
    }
}
