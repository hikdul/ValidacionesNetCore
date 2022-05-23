using System.ComponentModel.DataAnnotations;

namespace ValidacionesDTOs.Validaciones
{
    /// <summary>
    /// Para validar que la primera letra sea una letra mayuscula
    /// </summary>
    public class primeraLetraMayAttribute :ValidationAttribute
    {
        /// <summary>
        /// is valid, aqui ocurre la magia
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return ValidationResult.Success;

            var firtsLetter = value.ToString()[0].ToString();

            if(firtsLetter == firtsLetter.ToUpper())
                return ValidationResult.Success;

            return new ValidationResult("La Primera Letra Debe Ser Mayuscula");

        }

    }
}
