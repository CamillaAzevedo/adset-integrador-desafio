namespace AdsetIntegrator.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetbyId(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Add(TEntity entitie);
        void Dispose();
    }
}
