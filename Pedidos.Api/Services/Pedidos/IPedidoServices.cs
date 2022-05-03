using Pedidos.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Services.Pedidos
{
    public interface IPedidoServices
    {
        Task<IEnumerable<Pedido>> ListAsync();
        void AddAsync(Pedido pedido);
    }
}
