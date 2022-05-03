namespace Pedidos.Api.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public string NumeroCartao { get; set; }
        public int IdVenda { get; set; }
    }
}
