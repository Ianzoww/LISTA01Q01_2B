using Lista01Q01_2B.Services;
using Microsoft.AspNetCore.Mvc;
using Lista01Q01_2B.Models;

namespace Lista01Q01_2B.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    // Pedir = interface
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(Aluno dados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _alunoService.Inserir(dados);

            if (flInseriu)
                return Ok($"Aluno(a) {dados.nome} inserido com sucesso.");

            return BadRequest($"Aluno(a) {dados.nome} não inserido, " +
                $"cpf já existe.");

        }

        [HttpGet]
        [Route("ObterPorCpf")]
        public IActionResult ObterPorCpf(string cpf)
        {
            var alunoPesquisado = _alunoService.obterAlunosPorCpf(cpf);

            if (alunoPesquisado is null)
                return NotFound($"Aluno com cpf {cpf} não encontrado.");

            return Ok(alunoPesquisado);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_alunoService.obterTodosAlunos());
        }

    }
}
