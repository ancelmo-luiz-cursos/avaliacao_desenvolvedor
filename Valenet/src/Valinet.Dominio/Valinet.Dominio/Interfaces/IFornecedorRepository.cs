using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Dominio.Interfaces
{
    public interface IFornecedorRepository
    {
        Task Criar(Fornecedor fornecedor);
        Task<IEnumerable<Fornecedor>> Fornecedores();
        Task<Fornecedor> ObterFornecedor(Guid id);
    }
}
