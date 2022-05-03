using Microsoft.AspNetCore.Mvc;
using Recargas.Api.Models;
using Recargas.Api.Services.Recarga;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recargas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecargaController : ControllerBase
    {
        private readonly IRecargaServices _recargaServices;

        [HttpGet]
        public async Task<Recarga> GetByCartao(string numeroCartao)
        {
            return await _recargaServices.GetByRecarga(numeroCartao);
        }
    }
}
