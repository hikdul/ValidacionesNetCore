using System.ComponentModel.DataAnnotations;

namespace ValidacionesDTOs.DTO
{
    /// <summary>
    /// Clase de ejemplo para el uso de las validaciones
    /// </summary>
    public class ValidacionesPorModelo : IValidatableObject
    {
         /// <summary>
         /// Inicio de un periodo
         /// </summary>
        public DateTime inicio { get; set; }
        /// <summary>
        /// Fin De Un Periodo
        /// </summary>
        public DateTime fin { get; set; }

        /// <summary>
        /// Primera letra mayuscula
        /// </summary>
        public string PrimeraLetraMay { get; set; }
        /// <summary>
        /// Un Valor Positivo
        /// </summary>
        public int Positivo { get; set; }
        /// <summary>
        /// Aca ocurro la magia. genera las validaciones para este modelo e incluso se genera un retorno si es necesario
        /// Para este caso no necesitamos generar los decoradores, sino que al contrario el modelo siempre se valida.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!string.IsNullOrEmpty(this.PrimeraLetraMay.ToString()))
            {
                var pl = PrimeraLetraMay[0].ToString();
                if (pl != pl.ToUpper())
                    yield return new ValidationResult("La Primera Letra Debe ser mayuscula", new string[] { nameof(PrimeraLetraMay) });
            }    

            if(inicio>=fin)
                yield return new ValidationResult("Inicio debe ser menor que fin", new string[] { nameof(inicio) });

            if(Positivo<=0)
               yield return new ValidationResult("El Valor tiene que ser positivo/ >0", new string[]{nameof(Positivo)});

        }
    }
}
