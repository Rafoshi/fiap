using apicsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace apicsharp.Controllers
{
    [ApiController]
    [Route("Teste")]
    public class TesteController : ControllerBase
    {

        public TesteController()
        {
        }

        [HttpPost("Testar")]
        public ActionResult Criar(Teste teste)
        {
            try
            {
                return Ok("Funcionou!");
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}
