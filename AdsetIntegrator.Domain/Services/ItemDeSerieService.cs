using AdsetIntegrator.Domain.Entities;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Domain.Services
{
    public class ItemDeSerieService : ServiceBase<ItemDeSerie>, IItemDeSerieService
    {
        private readonly IItemDeSerieRepository _itemRepository;

        public ItemDeSerieService(IItemDeSerieRepository itemRepository) 
            : base (itemRepository) 
        {
            _itemRepository = itemRepository;
        }

        public IEnumerable<ItemDeSerie> BuscarPorNome(string nome)
        {
           return _itemRepository.BuscarPorNome(nome);
        }
    }
}
