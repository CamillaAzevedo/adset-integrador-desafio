using AdsetIntegrator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Infra.Data.EntityConfig
{
    public class ItemDeSerieConfiguration : EntityTypeConfiguration<ItemDeSerie>
    {
        public ItemDeSerieConfiguration() 
        {
            HasKey(i => i.ItemDeSerieId);

            Property(i => i.Nome)
                .HasMaxLength(150);

        }
    }
}
