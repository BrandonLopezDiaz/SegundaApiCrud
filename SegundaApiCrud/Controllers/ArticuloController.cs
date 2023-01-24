using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using SegundaApiCrud.Context;
using SegundaApiCrud.Entities;
using System.Threading.Tasks;

namespace SegundaApiCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticuloController : ControllerBase
    {
        public readonly ApplicationDbContext _context;
        public ArticuloController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Crear el constructor y llamar la conexion ala base de datos
        //_Context
        [HttpPost]
        public async Task<Articulo> Crear([FromBody] Articulo i)
        {
            var res = new Articulo
            {   
                Id = i.Id,
                Nombre = i.Nombre,
                Proveedor = i.Proveedor,
                Precio = i.Precio
                
            };
            _context.Add(res);
            //Llamar a entity para agregar 
            await _context.SaveChangesAsync();
            return res;
        }
        [HttpGet]
        public async Task<Articulo> Leer([FromBody] Articulo i) 
        {

        }
        [HttpPut]
        public async Task<Articulo> Actualizar([FromBody] Articulo i)
        {

        }
        [HttpDelete]
        public async Task<Articulo> Eliminar([FromBody] Articulo i)
        {

        }
    }
}
