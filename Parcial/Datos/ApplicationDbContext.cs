using Microsoft.EntityFrameworkCore;
using Parcial.Models;

namespace Parcial.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}
