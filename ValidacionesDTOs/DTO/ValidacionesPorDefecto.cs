using System.ComponentModel.DataAnnotations;

namespace ValidacionesDTOs.DTO
{
    /// <summary>
    /// en esta probaremos algunas validaciones que vienen por defecto con el sistema
    /// </summary>
    public class ValidacionesPorDefecto
    {
        /// <summary>
        /// Requerido
        /// </summary>
        [Required]
        public string  name { get; set; }

        /// <summary>
        /// que solo acepta numeros entro 10 y 15
        /// </summary>
        [Range(10,15)]
        public int number { get; set; }
        
        /// <summary>
        /// que tienen que ser direcciones de correo electronico
        /// </summary>
        [EmailAddress]
        public string email { get; set; }
        
        /// <summary>
        /// que sea una url valida 
        /// </summary>
        [Url]
        public string url { get; set; }
    }
}
