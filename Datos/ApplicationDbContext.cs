using form.Models;
using Microsoft.EntityFrameworkCore;

namespace form.Datos;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) :base(options)
    {
        
    }

    // Agregar los modelos
    public DbSet<Contacto> Contacto { get; set;}

}