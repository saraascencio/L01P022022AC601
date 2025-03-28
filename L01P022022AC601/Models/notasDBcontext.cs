using Microsoft.EntityFrameworkCore;

namespace L01P022022AC601.Models
{
    public class notasDBcontext : DbContext
    {
        public notasDBcontext(DbContextOptions<notasDBcontext> options) : base(options)
        {

        }

        public DbSet<alumnos> alumnos { get; set; }

        public DbSet<departamentos> departamentos { get; set; }

        public DbSet<facultades> facultades { get; set; }

        public DbSet<materias> materias { get; set; }
    }
}
