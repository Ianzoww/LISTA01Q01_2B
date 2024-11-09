using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Repository
{
    public class NotaAlunoRepository : INotaAlunoRepository
    {
        private static List<NotaAluno> listaNotasAlunos = new List<NotaAluno>();

        public List<NotaAluno> getAlunosAprovados()
        {
            return listaNotasAlunos.Where(n => n.Nota >= 7 && n.Frequencia >= 75).ToList();
        }

        public List<NotaAluno> getAlunosReprovados()
        {
            return listaNotasAlunos.Where(n => n.Nota < 7 || n.Frequencia < 75).ToList();
        }

        public void inserirNota(NotaAluno nota)
        {
            bool notaExistente = listaNotasAlunos.Any(n => n.RaAluno == nota.RaAluno && n.IdDisciplina == nota.IdDisciplina);

            if (notaExistente)
            {
                throw new InvalidOperationException("Já existe uma nota registrada para o aluno nesta disciplina.");
            }
            listaNotasAlunos.Add(nota);
        }
    }
}
