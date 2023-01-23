using Microsoft.EntityFrameworkCore;
using SegundaApiCrud.Entities;

namespace SegundaApiCrud.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }
        DbSet<Articulo> Articulos { get; set; } 
    }
}
