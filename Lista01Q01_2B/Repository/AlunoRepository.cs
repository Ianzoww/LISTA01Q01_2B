using Lista01Q01_2B.Models;
namespace Lista01Q01_2B.Repository

{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> dadosAlunosList = new List<Aluno>();

       
        public void Inserir(Aluno aluno)
        {
            dadosAlunosList.Add(aluno);

        }

        public Aluno obterAlunosPorCpf(string cpf)
        {
            return dadosAlunosList.Where(a => a.cpf == cpf).FirstOrDefault();
        }

        public Aluno obterAlunosPorRA(string ra)
        {
            return dadosAlunosList.Where(a => a.RA == ra).FirstOrDefault();
        }

        public List<Aluno> obterTodosAlunos()
        {
            return dadosAlunosList;
        }

        
    }
}
