using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;
using Valinet.Dominio.Interfaces;
using Valinet.Infra.Contexto;

namespace Valinet.Infra.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Cliente cliente)
        {
            _dataContext.Clientes.Add(cliente);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cliente>> Clientes()
        {
            return await _dataContext.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> ObterCliente(Guid id)
        {
            return await _dataContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
