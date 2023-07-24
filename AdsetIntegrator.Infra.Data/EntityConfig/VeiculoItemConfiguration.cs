using AdsetIntegrator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Infra.Data.EntityConfig
{
    public class VeiculoItemConfiguration : EntityTypeConfiguration<VeiculoItem>
    {
        public VeiculoItemConfiguration()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.Veiculo)
                .WithMany()
                .HasForeignKey(x => x.VeiculoId);

            HasRequired(x => x.ItemDeSerie)
                .WithMany()
                .HasForeignKey(x => x.ItemId);
        }
    }
}
