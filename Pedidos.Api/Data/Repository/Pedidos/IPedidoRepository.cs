using Pedidos.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Data.Repository.Pedidos
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> ListAsync();
        void AddAsync(Pedido pedido);
    }
}
