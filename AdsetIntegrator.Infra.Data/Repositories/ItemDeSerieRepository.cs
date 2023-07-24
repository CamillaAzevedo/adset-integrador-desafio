using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Infra.Data.Repositories
{
    public class ItemDeSerieRepository : RepositoryBase<ItemDeSerie>, IItemDeSerieRepository
    {
        public IEnumerable<ItemDeSerie> BuscarPorNome(string nome)
        {
            return Db.ItensDeSerie.Where(i => i.Nome == nome);
        }
    }
}
