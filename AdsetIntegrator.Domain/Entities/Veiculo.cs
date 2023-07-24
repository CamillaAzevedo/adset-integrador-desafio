namespace AdsetIntegrator.Domain.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public decimal Km { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public virtual IEnumerable<ItemDeSerie> ItensDeSerie { get; set; }
        public string Foto { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
