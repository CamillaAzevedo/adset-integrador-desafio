using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        TEntity GetbyId(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Add(TEntity entitie);
        void Dispose();
    }
}
