using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Dominio.Interfaces
{
    public interface IProdutoRepository
    {
        Task Criar(Produto produto);
        Task<IEnumerable<Produto>> Produtos();
        Task<Produto> ObterProduto(Guid id);
    }
}
