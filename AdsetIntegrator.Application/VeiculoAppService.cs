using AdsetIntegrator.Application.Interface;
using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Application
{
    public class VeiculoAppService : AppServiceBase<Veiculo>, IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoAppService(IVeiculoService veiculoService)
            : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }
    }
}
