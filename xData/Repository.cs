using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using xRepository._91128;
using Microsoft.EntityFrameworkCore;
using xData.Data;

namespace xData._91128
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly List<Expression<Func<TEntity, object>>> _includes;
        DbSet<TEntity> Table { get; set; }      
        public Repository(paymentContext context)
        {           
            Table = context.Set<TEntity>();
            _includes = new List<Expression<Func<TEntity, object>>>();
        }
        public async Task Add(TEntity obj) => await Table.AddAsync(obj);
        public async Task AddRange(IEnumerable<TEntity> list) => await Table.AddRangeAsync(list);
        public async Task<IEnumerable<TEntity>> All() => await Include(_includes).AsNoTracking().ToListAsync();
        public void Delete(TEntity obj) => Table.Remove(obj);
        public void Delete(IEnumerable<TEntity> list) => Table.RemoveRange(list);
        public Task<TEntity> GetById(int id) => Include(_includes).SingleAsync(x => x.uid.Equals(id));
        public void Update(TEntity obj) => Table.Update(obj);
        public void Update(IEnumerable<TEntity> list) => Table.UpdateRange(list);
        public IQueryable<TEntity> where(Expression<Func<TEntity, bool>> expression) => Include(_includes).Where(expression);
        public IQueryable<TEntity> Queryable() => Table;
        public IEnumerable<TEntity> StoredQueryable(string sql, params object[] parameters) => Table.FromSqlRaw(sql, parameters).ToList();
        public IEnumerable<TEntity> StoredInterpolated(FormattableString sql) => Table.FromSqlInterpolated(sql).ToList();
        public IEnumerable<TEntity> SelectAsync() => Include(_includes);
        public IQueryable<TEntity> Include(List<Expression<Func<TEntity, object>>> expression)
        {
            IQueryable<TEntity> query = Table;
            if (expression != null)
            {
                query = expression.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;            
        }
        public IRepository<TEntity> addIncludes(Expression<Func<TEntity, object>> expression)
        {
            _includes.Add(expression);
            return this;
        }       
    }
}
