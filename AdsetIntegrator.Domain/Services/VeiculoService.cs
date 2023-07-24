using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Domain.Interfaces.Services;

namespace AdsetIntegrator.Domain.Services
{
    public class VeiculoService : ServiceBase<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
            : base(veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
    }
}
