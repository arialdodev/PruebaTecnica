
using Microsoft.EntityFrameworkCore;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;

namespace PruebaTecnicaLlamada.Infrastructure.Persistence
{
    public class PruebaTecnicaLlamadaDbContext : DbContext
    {
        public PruebaTecnicaLlamadaDbContext(DbContextOptions<PruebaTecnicaLlamadaDbContext> options) 
        : base(options)
        {  
        }

        public DbSet<Deportista> Deportistas => Set<Deportista>();
        public DbSet<Intentos> Intentos => Set<Intentos>();

    }
}
