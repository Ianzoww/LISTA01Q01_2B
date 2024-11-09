using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Services
{ 
        public interface IAlunoService
        {
            public List<Aluno> obterTodosAlunos();
            public Aluno obterAlunosPorCpf(string cpf);
            public Aluno obterAlunosPorRA(string cpf);

            public bool Inserir(Aluno novoAluno);
        }
}
