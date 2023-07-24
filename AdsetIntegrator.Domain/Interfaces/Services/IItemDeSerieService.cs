using AdsetIntegrator.Domain.Entities;

namespace AdsetIntegrator.Domain.Interfaces.Services
{
    public interface IItemDeSerieService : IServiceBase<ItemDeSerie>
    {
        IEnumerable<ItemDeSerie> BuscarPorNome(string nome);
    }
}
