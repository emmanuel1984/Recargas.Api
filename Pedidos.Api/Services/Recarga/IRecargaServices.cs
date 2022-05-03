using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recargas.Api.Services.Recarga
{
    public interface IRecargaServices
    {
        Task<Models.Recarga> GetByRecarga(string numeroCartao);
    }
}
