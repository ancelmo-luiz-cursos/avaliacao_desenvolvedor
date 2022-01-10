
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Valinet.Dominio.Interfaces;
using Valinet.Historia.Pedidos;
using Valinet.Web.Mappers;

namespace Valinet.Web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ConsultaPedidos _consultaPedidos;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _consultaPedidos = new ConsultaPedidos(pedidoRepository);
        }

        public async Task<IActionResult> Index()
        {
            var pedidos = await _consultaPedidos.ListarPedidos();
            var pedidosViewModel = PedidoMapper.ListaPedidosViewModel(pedidos);

            return View(pedidosViewModel);
        }
    }
}
