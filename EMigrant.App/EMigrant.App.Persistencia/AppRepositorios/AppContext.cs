using Microsoft.EntityFrameworkCore;
using EMigrant.App.Dominio;

namespace EMigrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrantes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GRUPOONCE");
            }
        }
    }
}
