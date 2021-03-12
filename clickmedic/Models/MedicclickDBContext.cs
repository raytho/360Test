using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace clickmedic.Models
{
    public class MedicclickDBContext : DbContext
    {        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alergia> Alergias { get; set; } 

        public MedicclickDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Startup.StaticConfiguration.GetValue<string>("ConnectionStrings:DefaultConnection");
            optionsBuilder
                    .UseSqlServer(connectionString);
        }
    }
}
