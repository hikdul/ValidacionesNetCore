using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidacionesDTOs.DTO;

namespace ValidacionesDTOs.Controllers
{
    /// <summary>
    /// solo es un controlado para probar las validaciones con el uso de swagger
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValidacionesController : ControllerBase
    {

        /// <summary>
        /// Para la prueba con validaciones por defecto
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        [HttpPost("ValidacionesPorDefecto")]
        public ActionResult  Post(ValidacionesPorDefecto datos)
        {
            return Ok(datos);
        }
        /// <summary>
        /// Verifica las validacinose por atributo
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        [HttpPost("ValidacionesPorAtributo")]
        public ActionResult Post(ValidacionesPorAtributo datos)
        {
            return Ok(datos);
                 
        }
        /// <summary>
        /// Para las validaciones por modelo
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        [HttpPost("ValidacionesPorModelo")]
        public ActionResult Post(ValidacionesPorModelo  datos)
        {
            return Ok(datos); 
        }


        
    }
}
