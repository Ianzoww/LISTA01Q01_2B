using Lista01Q01_2B.Models;
using Lista01Q01_2B.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lista01Q01_2B.Controllers
{
    [Route("api/notaAluno")]
    public class NotaAlunoController : ControllerBase
    {

        private readonly INotaAlunoService _notaAlunoService;

        public NotaAlunoController(INotaAlunoService notaAlunoService)
        {
            _notaAlunoService = notaAlunoService;
        }
        [HttpPost]
        [Route("InserirNota")]
        public IActionResult InserirNota([FromBody] NotaAluno nota)
        {
            try
            {
                _notaAlunoService.InserirNota(nota);
                return Ok("Nota inserida com sucesso.");
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}
