using Lista01Q01_2B.Models;
using Lista01Q01_2B.Repository;

namespace Lista01Q01_2B.Services
{
    public class NotaAlunoService : INotaAlunoService
    {
        private List<NotaAluno> listaNotasAlunos = new List<NotaAluno>();

        private readonly IAlunoRepository _alunoRepository; // Para verificar se o aluno existe
        private readonly IDisciplinaRepository _disciplinaRepository; // Para verificar se a disciplina existe

        public NotaAlunoService(IAlunoRepository alunoRepository, IDisciplinaRepository disciplinaRepository)
        {
            _alunoRepository = alunoRepository;
            _disciplinaRepository = disciplinaRepository;
        }

        public void InserirNota(NotaAluno nota)
        {
            // Verifica se o aluno existe
            var alunoExistente = _alunoRepository.obterAlunosPorRA(nota.RaAluno);
            if (alunoExistente == null)
            {
                throw new InvalidOperationException("O aluno não existe.");
            }

            // Verifica se a disciplina existe
            var disciplinaExistente = _disciplinaRepository.getDisciplinaPorNome(nota.IdDisciplina.ToString()); 
            if (disciplinaExistente == null)
            {
                throw new InvalidOperationException("A disciplina não existe.");
            }

            // Verifica se já existe uma nota para o mesmo aluno na mesma disciplina
            bool notaExistente = listaNotasAlunos.Any(n => n.RaAluno == nota.RaAluno && n.IdDisciplina == nota.IdDisciplina);
            if (notaExistente)
            {
                throw new InvalidOperationException("Já existe uma nota registrada para o aluno nesta disciplina.");
            }

            listaNotasAlunos.Add(nota);
        }
    }
}
