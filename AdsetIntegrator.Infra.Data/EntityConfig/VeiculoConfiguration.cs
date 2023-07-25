using AdsetIntegrator.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

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

            Property(v => v.Foto.FirstOrDefault()).HasMaxLength(255);

            Property(v => v.DataDeCadastro)
                .HasColumnType("datetime2");

        }
    }
}
