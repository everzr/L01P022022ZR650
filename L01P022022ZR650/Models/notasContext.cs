using Microsoft.EntityFrameworkCore;

namespace L01P022022ZR650.Models
{
    public class notasContext : DbContext
    {
        public notasContext(DbContextOptions<notasContext> options) : base(options) { }

        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
    }
}
