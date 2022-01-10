using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valinet.Web.Models
{
    public class ProdutoViewModel
    {
        public string Descricao { get;  set; }
        public Decimal Preco { get;  set; }
        public FornecedorViewModel Fornecedor { get;  set; }
    }
}
