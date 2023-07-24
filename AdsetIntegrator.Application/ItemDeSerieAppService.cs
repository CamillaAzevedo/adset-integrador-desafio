using AdsetIntegrator.Application.Interface;
using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Application
{
    public class ItemDeSerieAppService : AppServiceBase<ItemDeSerie>, IItemDeSerieAppService
    {
        private readonly IItemDeSerieService _itemService;

        public ItemDeSerieAppService(IItemDeSerieService itemService)
            : base(itemService)
        {
            _itemService = itemService;
        }

        public IEnumerable<ItemDeSerie> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
