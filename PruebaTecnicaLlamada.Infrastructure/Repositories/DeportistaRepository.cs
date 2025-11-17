using Microsoft.EntityFrameworkCore;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.SeedWork;
using PruebaTecnicaLlamada.Infrastructure.Persistence;

namespace PruebaTecnicaLlamada.Infrastructure.Repositories
{
    public class DeportistaRepository : IRepository<Deportista>
    {
        public readonly PruebaTecnicaLlamadaDbContext _pruebaTecnicaLlamadaDbContext;

        public DeportistaRepository(PruebaTecnicaLlamadaDbContext pruebaTecnicaLlamadaDbContext)
        {
            _pruebaTecnicaLlamadaDbContext = pruebaTecnicaLlamadaDbContext;
        }

        public async Task<bool> Create(Deportista entity)
        {
            await _pruebaTecnicaLlamadaDbContext.Deportistas.AddAsync(entity);
            await _pruebaTecnicaLlamadaDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Deportista>> GetAll(int? deportistaId)
        {
            if (deportistaId.HasValue)
            {
                return await _pruebaTecnicaLlamadaDbContext.Deportistas
                    .Where(d => d.Id == deportistaId.Value)
                    .ToListAsync();
            }
            else
            {
                return await _pruebaTecnicaLlamadaDbContext.Deportistas
                    .ToListAsync();
            }
        }


    }
}
