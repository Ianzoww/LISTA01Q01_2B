using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Repository
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        static List<Disciplina> listaDisciplinas = new List<Disciplina>();

        public void inserirDisciplina(Disciplina disciplina)
        {
            listaDisciplinas.Add(disciplina);
        }

        public List<Disciplina> getDisciplina()
        {
            return listaDisciplinas;
        }


        public Disciplina getDisciplinaPorNome(string nome)
        {
            return listaDisciplinas.FirstOrDefault(d => d.Nome == nome);
        }
    }
}
