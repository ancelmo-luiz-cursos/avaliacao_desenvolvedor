using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Dominio.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> ListarPedidos();
    }
}
