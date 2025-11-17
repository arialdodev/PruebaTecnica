using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PruebaTecnicaLlamada.Infrastructure.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PruebaTecnicaLlamadaDbContext>
    {
        public PruebaTecnicaLlamadaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PruebaTecnicaLlamadaDbContext>();

            builder.UseSqlServer("Server=Breidy;Database=PruebaTecnicaLlamadaDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new PruebaTecnicaLlamadaDbContext(builder.Options);
        }
    }
}
