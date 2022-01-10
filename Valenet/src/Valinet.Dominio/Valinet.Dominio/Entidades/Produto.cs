using System;

namespace Valinet.Dominio.Entidades
{
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public Guid FornecedorId { get; private set; }
        public string Descricao { get; private set; }
        public Decimal Preco { get; private set; }
      

        public Fornecedor Fornecedor { get; private set; }
    }
}
