namespace Recargas.Api.Models
{
    public class BaixarRecargas
    {
        public int IdPedido { get; set; }
        public string NumeroCartao { get; set; }
        public decimal Valor { get; set; }
    }
}
