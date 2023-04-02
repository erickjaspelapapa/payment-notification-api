using System.Linq.Expressions;

namespace xRepository._91128
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task Add(TEntity obj);
        Task AddRange(IEnumerable<TEntity> list);
        void Update(TEntity obj);
        void Update(IEnumerable<TEntity> list);
        void Delete(TEntity obj);
        void Delete(IEnumerable<TEntity> list);
        Task<IEnumerable<TEntity>> All();
        Task<TEntity> GetById(int id);
        IQueryable<TEntity> where(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> Include(List<Expression<Func<TEntity, object>>> expression);
        IRepository<TEntity> addIncludes(Expression<Func<TEntity, object>> expression);
        IEnumerable<TEntity> StoredQueryable(string sql, params object[] parameters);
        IEnumerable<TEntity> StoredInterpolated(FormattableString sql);
        IEnumerable<TEntity> SelectAsync();

    }
}
