using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valinet.Dominio.Entidades
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public int Quantidade { get; private set; }

        public Cliente Cliente { get; private set; }
        public Produto Produto { get; private set; }
    }
}
