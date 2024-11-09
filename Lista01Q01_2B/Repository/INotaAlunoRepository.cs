using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Repository
{
    public interface INotaAlunoRepository
    {
        public void inserirNota(NotaAluno nota);

        public List<NotaAluno> getAlunosAprovados();
        public List<NotaAluno> getAlunosReprovados();
    }
}
