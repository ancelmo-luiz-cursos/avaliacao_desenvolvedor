using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;
using Valinet.Dominio.Interfaces;
using Valinet.Infra.Contexto;

namespace Valinet.Infra.Repositorios
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _dataContext;

        public PedidoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Pedido>> ListarPedidos()
        {
            return await _dataContext.Pedidos.AsNoTracking().ToListAsync();
        }
    }
}
