using apicsharp.Models;
using apicsharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace apicsharp.Controllers
{
    [ApiController]
    [Route("Teste")]
    public class TesteController : ControllerBase
    {
        private readonly ITesteService _testeService;

        public TesteController(ITesteService testeService)
        {
            _testeService = testeService;
        }

        [HttpGet("GetAll")]
        public ActionResult Create()
        {
            try
            {
                var result = _testeService.GetAll();
                return Ok(result);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            try
            {
                var result = _testeService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public ActionResult Create(Teste teste)
        {
            try
            {
                int idCreated = _testeService.Create(teste);
                return Ok(idCreated);
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public ActionResult Update(Teste teste)
        {
            try
            {
                _testeService.Update(teste);
                return Ok();
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            try
            {
                _testeService.Delete(id);
                return Ok();
            }
            catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}
