using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdsetIntegrador.MVC.ViewModels
{
    public class ItemDeSerieViewModel
    {
        [Key]
        public int ItemDeSerieId { get; set; }
        public string Nome { get; set; }
    }
}