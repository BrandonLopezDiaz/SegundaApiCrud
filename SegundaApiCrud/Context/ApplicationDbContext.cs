using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SegundaApiCrud.Entities;
using System;

namespace SegundaApiCrud.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }
        DbSet<Articulo> Articulos { get; set; }

        public static implicit operator ApplicationBuilder(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
