using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using SegundaApiCrud.Entities;
using System.Threading.Tasks;

namespace SegundaApiCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticuloController : ControllerBase
    {
        public readonly ApplicationBuilder _context
        
        //Crear el constructor y llamar la conexion ala base de datos
        //_Context
        [HttpPost]
        public async Task<Articulo> Crear([FromBody] Articulo i)
        {
            var res = new Articulo
            {
                Nombre = i.Nombre,
                Precio = i.Precio,
                Proveedor = i.Proveedor,
                Id = i.Id
            };
            _context.Add(res)
            //Llamar a entity para agregar 
            await _context.saveChangeAsync();
            return Ok();
        }
    }
}
