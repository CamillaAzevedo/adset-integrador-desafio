using AdsetIntegrator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsetIntegrator.Infra.Data.EntityConfig
{
    public class VeiculoConfiguration : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfiguration() 
        {
            HasKey(v => v.VeiculoId);

            Property(v => v.Marca)
                .IsRequired()
                .HasMaxLength(50);

            Property(v => v.Modelo)
                .IsRequired()
                .HasMaxLength(100);

            Property(v => v.Ano)
                .IsRequired();

            Property(v => v.Placa)
                .IsRequired()
                .HasMaxLength(10);

            Property(v => v.Cor)
                .IsRequired()
                .HasMaxLength(10);

            Property(v => v.Preco)
               .IsRequired();

            Property(v => v.Foto)
              .HasMaxLength(255);

        }
    }
}
