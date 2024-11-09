using System.ComponentModel.DataAnnotations;

namespace Lista01Q01_2B.Models
{
    public class Disciplina
    {
        [Required(ErrorMessage = "Obrigatório")]
        public int idDiscplina { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Curso { get; set; }
    }
}
