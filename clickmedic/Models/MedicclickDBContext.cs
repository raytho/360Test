using System;
using Microsoft.EntityFrameworkCore;

namespace clickmedic.Models
{
    public class MedicclickDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alergia> Alergias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer(@"Data Source=mediclick.database.windows.net;Initial Catalog=MediclickDB;User Id=raymundosp; Password=.Somoshiroystacy");
        }
    }
}
