using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;
using Valinet.Dominio.Interfaces;
using Valinet.Infra.Contexto;

namespace Valinet.Infra.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Produto produto)
        {
            _dataContext.Produtos.Add(produto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Produto>> Produtos()
        {
            return await _dataContext.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterProduto(Guid id)
        {
            return await _dataContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
