using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Dominio.Interfaces
{
    public interface IClienteRepository
    {
        Task Criar(Cliente cliente);
        Task<IEnumerable<Cliente>> Clientes();
        Task<Cliente> ObterCliente(Guid id);
    }
}
