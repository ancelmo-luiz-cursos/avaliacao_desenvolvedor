using System;
using System.Collections.Generic;

namespace Valinet.Dominio.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public IEnumerable<Pedido> Pedidos { get; private set; }
    }
}
