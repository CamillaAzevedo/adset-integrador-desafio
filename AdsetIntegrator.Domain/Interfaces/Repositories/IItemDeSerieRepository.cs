using AdsetIntegrator.Domain.Entities;

namespace AdsetIntegrator.Domain.Interfaces.Repositories
{
    public interface IItemDeSerieRepository : IRepositoryBase<ItemDeSerie>
    {
        IEnumerable<ItemDeSerie> BuscarPorNome(string nome);
    }
}
