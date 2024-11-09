using Lista01Q01_2B.Repository;
using Lista01Q01_2B.Models;

namespace Lista01Q01_2B.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public bool Inserir(Aluno novoAluno)
        {
            Aluno dadosAluno = _alunoRepository.obterAlunosPorCpf(novoAluno.cpf);
            // Regra para verificar se o aluno ja existe

            if (dadosAluno is not null) 
            {
                return false;
            }
                
            dadosAluno = _alunoRepository.obterAlunosPorRA(novoAluno.RA);

            if (dadosAluno is null)
            {
                _alunoRepository.Inserir(novoAluno);
                return true;
            }
            return false;

        }

        public Aluno obterAlunosPorCpf(string cpf)
        {
            return _alunoRepository.obterAlunosPorCpf(cpf);
        }

        public Aluno obterAlunosPorRA(string ra)
        {
            return _alunoRepository.obterAlunosPorRA(ra);
        }

        public List<Aluno> obterTodosAlunos()
        {
            return _alunoRepository.obterTodosAlunos();
        }
    }
}
