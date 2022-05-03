using Microsoft.AspNetCore.Mvc;
using Recargas.Api.Models;
using Recargas.Api.Services.BaixarRecargas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recargas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaixarRecargasController : Controller
    {
        private readonly IBaixarRecargaServices _baixarRecargaServices;

        [HttpGet]
        public async Task<IEnumerable<BaixarRecargas>> GetAllAsync(string status)
        {
            return await _baixarRecargaServices.ListAsync(status);
        }
    }
}
