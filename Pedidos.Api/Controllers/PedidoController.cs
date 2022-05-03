using Microsoft.AspNetCore.Mvc;
using Pedidos.Api.Models;
using Pedidos.Api.Services.Pedidos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoServices _pedidoServices;

        public PedidoController(IPedidoServices pedidoServices)
        {
            _pedidoServices = pedidoServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _pedidoServices.ListAsync();
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Pedido pedido)
        {
            if (pedido == null)
            {
                return BadRequest();
            }
            _pedidoServices.AddAsync(pedido);

            return CreatedAtRoute("", new { Controller = "Pedido", id = pedido.NumeroCartao }, pedido);
        }
    }
}
