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
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
    }
}
