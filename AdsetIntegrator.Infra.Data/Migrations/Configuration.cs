namespace AdsetIntegrator.Infra.Data.Migrations
{
    using AdsetIntegrator.Domain.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.AdsIntegratorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.AdsIntegratorContext context)
        {
            context.ItensDeSerie.AddOrUpdate(
                new ItemDeSerie() { Nome = "Banco de Couro" },
                new ItemDeSerie() { Nome = "Vidro elétrico" },
                new ItemDeSerie() { Nome = "Central Multimídia" }
            );
            context.SaveChanges();
        }
    }
}
