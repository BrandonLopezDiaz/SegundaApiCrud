
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegundaApiCrud.Context;
using SegundaApiCrud.Entities;
using System;
using System.Collections.Generic;
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
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }

        }
        [HttpGet]
        public async Task<List<Articulo>> Leer()
        {
            try
            {
                var res= await _context.Articulos.ToListAsync();
                
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
        [HttpPut]
        public async Task<Articulo> Actualizar([FromBody] Articulo i)
        {
            try
            {
                var res = new Articulo
                {
                    Id = i.Id,
                    Nombre = i.Nombre,
                    Proveedor = i.Proveedor,
                    Precio = i.Precio
                };
                _context.Update(res);
                //Llamar a entity para agregar 
                await _context.SaveChangesAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
        [HttpDelete]
        public async Task<Articulo> Eliminar(int i)
        {
            try
            {
                var res = new Articulo
                {
                    Id = i
                };
                _context.Remove(res);
                //Llamar a entity para agregar 
                await _context.SaveChangesAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
