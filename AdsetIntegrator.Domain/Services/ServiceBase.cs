using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Domain.Interfaces.Services;

namespace AdsetIntegrator.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entitie)
        {
            _repository.Add(entitie);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public void Dispose()
        {
           _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetbyId(int id)
        {
            return _repository.GetbyId(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
