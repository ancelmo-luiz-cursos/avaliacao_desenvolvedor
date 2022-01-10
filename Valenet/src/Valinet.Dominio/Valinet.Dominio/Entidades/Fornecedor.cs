using System;
using System.Collections.Generic;

namespace Valinet.Dominio.Entidades
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public IEnumerable<Produto> Produtos { get; private set; }
    }
}
