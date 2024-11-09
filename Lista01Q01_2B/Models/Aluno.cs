using System.ComponentModel.DataAnnotations;
using Lista01Q01_2B.Validation;

namespace Lista01Q01_2B.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Obrigatório")]

        public string telefone { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string cpf { get; set; }
        [MaioridadeValidation(ErrorMessage = "Erro idade")]
        public int idade { get; set; }

        public string RA { get; set; }
        
    }
}
