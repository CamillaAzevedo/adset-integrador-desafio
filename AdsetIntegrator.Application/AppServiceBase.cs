using AdsetIntegrator.Application.Interface;
using AdsetIntegrator.Domain.Interfaces.Services;

namespace AdsetIntegrator.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity entitie)
        {
            _serviceBase.Add(entitie);
        }

        public void Delete(TEntity entity)
        {
            _serviceBase.Delete(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _serviceBase.GetAll();
        }

        public TEntity GetbyId(int id)
        {
           return _serviceBase.GetbyId(id);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
