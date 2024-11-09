using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Repository

{
    public interface IDisciplinaRepository
    {
        public void inserirDisciplina(Disciplina disciplina);

        public Disciplina getDisciplinaPorNome(string nome);

        public List<Disciplina> getDisciplina();
    }
}
