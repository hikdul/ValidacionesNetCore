using ValidacionesDTOs.Validaciones;

namespace ValidacionesDTOs.DTO
{
    public class ValidacionesPorAtributo
    {
        /// <summary>
        /// solo es una palabra
        /// </summary>
        [primeraLetraMay]
        public string  palabra1 { get; set; }

        /// <summary>
        /// segunda palabra
        /// </summary>
        [primeraLetraMay]
        public string palabra2 { get; set; }
    }
}
