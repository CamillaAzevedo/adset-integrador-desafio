using AdsetIntegrator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Application.Interface
{
    public interface IItemDeSerieAppService : IAppServiceBase<ItemDeSerie>
    {
        IEnumerable<ItemDeSerie> BuscarPorNome(string nome);
    }
}
