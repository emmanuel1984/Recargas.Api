using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recargas.Api.Services.BaixarRecargas
{
    public class BaixarRecargaServices : IBaixarRecargaServices
    {
        public Task<IEnumerable<Models.BaixarRecargas>> ListAsync(string status)
        {
            throw new System.NotImplementedException();
        }
    }
}
