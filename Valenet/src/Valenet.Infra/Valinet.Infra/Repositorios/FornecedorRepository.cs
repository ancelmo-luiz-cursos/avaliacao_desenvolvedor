using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;
using Valinet.Dominio.Interfaces;
using Valinet.Infra.Contexto;

namespace Valinet.Infra.Repositorios
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly DataContext _dataContext;

        public FornecedorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Fornecedor fornecedor)
        {
            _dataContext.Fornecedores.Add(fornecedor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Fornecedor>> Fornecedores()
        {
            return await _dataContext.Fornecedores.AsNoTracking().ToListAsync();
        }

        public async Task<Fornecedor> ObterFornecedor(Guid id)
        {
            return await _dataContext.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
