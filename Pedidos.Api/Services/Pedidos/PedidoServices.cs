using Pedidos.Api.Data.Repository.Pedidos;
using Pedidos.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Services.Pedidos
{
    public class PedidoServices : IPedidoServices
    {
        private IPedidoRepository _pedidoRepository;

        public PedidoServices(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public void AddAsync(Pedido pedido)
        {
            _pedidoRepository.AddAsync(pedido);
        }

        public async Task<IEnumerable<Pedido>> ListAsync()
        {
            return await _pedidoRepository.ListAsync();
        }
    }
}
