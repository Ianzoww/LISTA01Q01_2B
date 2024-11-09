using Lista01Q01_2B.Services;
using Microsoft.AspNetCore.Mvc;
using Lista01Q01_2B.Models;

namespace Lista01Q01_2B.Controllers
{
    [ApiController]
    [Route("api/disciplina")]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(Disciplina disciplina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool insert = _disciplinaService.inserirDisciplina(disciplina);

            if (insert is true)
                return Ok($"Disciplina {disciplina.Nome} inserida com sucesso.");

            return BadRequest($"A disciplina {disciplina.Nome} já existe.");

        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_disciplinaService.getDisciplina());
        }
    }
}
