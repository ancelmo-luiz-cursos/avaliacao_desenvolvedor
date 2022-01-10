using System.Collections.Generic;
using Valinet.Dominio.Entidades;
using Valinet.Web.Models;

namespace Valinet.Web.Mappers
{
    public static class PedidoMapper
    {
        public static PedidoViewModel PedidoParaPedidoViewModel(Pedido pedido)
        {
            var pedidoViewModel = new PedidoViewModel()
            {
               Comprador = pedido.Cliente.Nome,
               Descricao = pedido.Produto.Descricao,
               PrecoUnitario = pedido.Produto.Preco,
               Quantidade = pedido.Quantidade,
               Endereco = pedido.Cliente.Endereco,
               Fornecedor = pedido.Produto.Fornecedor.Nome
            };

            return pedidoViewModel;
        }

        public static IEnumerable<PedidoViewModel> ListaPedidosViewModel(IEnumerable<Pedido> pedidos)
        {
            var lista = new List<PedidoViewModel>();

            foreach (var item in pedidos)
            {
                lista.Add(PedidoParaPedidoViewModel(item));
            }

            return lista;
        }
    }
}
