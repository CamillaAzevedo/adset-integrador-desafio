using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Domain.Entities
{
    public class VeiculoItem
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public int ItemId { get; set; }
        public virtual ItemDeSerie ItemDeSerie { get; set; }

    }
}
