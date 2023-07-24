using System;
using System.Collections.Generic;


namespace AdsetIntegrator.MVC.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int VeiculoId { get; set; }
        [Required(ErrorMessage = "Preencha a Marca")]
        [MaxLength(50)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Preencha o Modelo")]
        [MaxLength (100)]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Preencha o Ano")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "Preencha a Placa")]
        [MaxLength (10)]
        public string Placa { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        public decimal Km { get; set; }
        [Required(ErrorMessage = "Preencha a Cor")]
        [MaxLength (10)]
        public string Cor { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","9999999999")]
        [Required(ErrorMessage = "Preencha o Preço")]
        public decimal Preco { get; set; }
        [MaxLength (255)]
        public string Foto { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataDeCadastro { get; set; }
        public virtual IEnumerable<ItemDeSerieViewModel> ItensDeSerie { get; set; }
    }
}