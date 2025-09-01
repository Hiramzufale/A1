using Microsoft.EntityFrameworkCore;
using webApplication1.Models;

namespace webApplication1.Data;
public class ApplicationDbContext : DbContext
{
    // Constructor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Establecemos un DbSet para la entidad Cancion
    public DbSet<Cancion> canciones { get; set; }
}