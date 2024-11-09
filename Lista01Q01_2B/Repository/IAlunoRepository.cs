using Lista01Q01_2B.Models;

namespace Lista01Q01_2B.Repository
{
    public interface IAlunoRepository
    {
        public List<Aluno> obterTodosAlunos();
        public Aluno obterAlunosPorCpf(string cpf);

        public void Inserir(Aluno novoAluno);
        public Aluno obterAlunosPorRA(string ra);
    }
}
