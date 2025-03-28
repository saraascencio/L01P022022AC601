using Microsoft.EntityFrameworkCore;

namespace L01P022022AC601.Models
{
    public class notasDBcontext : DbContext
    {
        public notasDBcontext(DbContextOptions<notasDBcontext> options) : base(options)
        {

        }

        //public DbSet<marcas> marcas { get; set; }
    }
}
