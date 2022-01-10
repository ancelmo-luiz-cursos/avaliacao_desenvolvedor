using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Valinet.Web.Models
{
    public class PedidoViewModel
    {
        [Display(Name = "Comprador")]
        public string Comprador { get; set; }


        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Preço Unitário")]
        public Decimal PrecoUnitario { get; set; }


        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }


        [Display(Name = "Endereço")]
        public string Endereco { get; set; }


        [Display(Name = "Fornecedor")]
        public string Fornecedor { get; set; }
    }
}
