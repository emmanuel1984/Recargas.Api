using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recargas.Api.Services.BaixarRecargas
{
    public interface IBaixarRecargaServices
    {
        Task<IEnumerable<Models.BaixarRecargas>> ListAsync(string Status);
    }
}
