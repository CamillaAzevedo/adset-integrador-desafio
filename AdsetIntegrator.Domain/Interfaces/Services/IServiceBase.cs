namespace AdsetIntegrator.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class 
    {
        TEntity GetbyId(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Add(TEntity entitie);
        void Dispose();
    }
}
