using AdsetIntegrator.Domain.Interfaces;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected AdsIntegratorContext Db = new AdsIntegratorContext();
        public void Add(TEntity entitie)
        {
            Db.Set<TEntity>().Add(entitie);
            Db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetbyId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
