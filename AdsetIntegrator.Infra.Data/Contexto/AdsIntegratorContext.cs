using AdsetIntegrator.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AdsetIntegrator.Infra.Data.EntityConfig;

namespace AdsetIntegrator.Infra.Data.Contexto
{
    public class AdsIntegratorContext : DbContext
    {
        public AdsIntegratorContext() : base("AdsIntegrator") 
        {

        }

        public DbSet<Veiculo> Veiculo { get; set;}
        public DbSet<ItemDeSerie> ItensDeSerie { get; set;}
        public DbSet<VeiculoItem> VeiculoItems { get; set;}

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
             modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
             modelBuilder.Properties()
                 .Where(a => a.Name == a.ReflectedType.Name + "Id")
                 .Configure(a => a.IsKey());
            modelBuilder.Configurations.Add(new VeiculoConfiguration());
            modelBuilder.Configurations.Add(new ItemDeSerieConfiguration());
            modelBuilder.Configurations.Add(new VeiculoItemConfiguration());
        }

         public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null ))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadstro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
