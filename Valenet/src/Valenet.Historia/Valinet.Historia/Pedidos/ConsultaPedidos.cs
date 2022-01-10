using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;
using Valinet.Dominio.Interfaces;

namespace Valinet.Historia.Pedidos
{
    public class ConsultaPedidos
    {
        private readonly IPedidoRepository _repository;
        public ConsultaPedidos(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Pedido>> ListarPedidos()
        {
            var pediddos = await _repository.ListarPedidos();

            return pediddos;
        }
    }
}
