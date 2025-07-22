using Microsoft.EntityFrameworkCore;

namespace Clinica.Data {
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.ClientEntity> Clientes { get; set; }
        public DbSet<Entities.MedicoEntity> Medicos { get; set; }
        public DbSet<Entities.ConsultaEntity> Consultas { get; set; }
        public DbSet<Entities.ConsultaClientEntity> ConsultaClients { get; set; }
       


    }
}
