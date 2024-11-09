using Lista01Q01_2B.Models;

namespace Lista01Q01_2B.Services
{
    public interface IDisciplinaService
    {
        public bool inserirDisciplina(Disciplina disciplina);

        public List<Disciplina> getDisciplina();
    }
}
