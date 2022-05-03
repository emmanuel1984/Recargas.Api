using Microsoft.EntityFrameworkCore;
using Pedidos.Api.Data.Context;
using Pedidos.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Data.Repository.Pedidos
{
    public class PedidoRepository : BaseRepository, IPedidoRepository
    {
        public PedidoRepository(AppDbContext context) : base(context) { }
        public async void AddAsync(Pedido pedido)
        {
            _context.Pedido.AddAsync(pedido);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Pedido>> ListAsync()
        {
            return await _context.Pedido.ToListAsync();
        }
    }
}
