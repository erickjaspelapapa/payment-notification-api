namespace xRepository._91128
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntity;
        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);
        Task Commit();
    }
}
