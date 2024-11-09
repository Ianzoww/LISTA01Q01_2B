using System.ComponentModel.DataAnnotations;

namespace Lista01Q01_2B.Validation
{

    public class MaioridadeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            int idade = (int)value;

            return idade >= 18 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }

}
