using Microsoft.EntityFrameworkCore;
using Pedidos.Api.Models;

namespace Pedidos.Api.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pedido>().HasKey(p => p.Id);
            builder.Entity<Pedido>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pedido>().Property(p => p.Status).IsRequired().HasMaxLength(50);
            builder.Entity<Pedido>().Property(p => p.NumeroCartao).IsRequired().HasMaxLength(16);
            builder.Entity<Pedido>().Property(p => p.Valor).IsRequired();
            builder.Entity<Pedido>().Property(p => p.IdVenda).IsRequired();
        }
    }
}
