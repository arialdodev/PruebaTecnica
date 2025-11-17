using Microsoft.EntityFrameworkCore;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.Commond;
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

        public async Task<Result<bool>> Create(Deportista entity)
        {
            await _pruebaTecnicaLlamadaDbContext.Deportistas.AddAsync(entity);
            await _pruebaTecnicaLlamadaDbContext.SaveChangesAsync();
            return Result<bool>.Success(true);
        }

        public async Task<Result<List<Deportista>>> GetAll(int? deportistaId)
        {
            try
            {
                IQueryable<Deportista> query = _pruebaTecnicaLlamadaDbContext.Deportistas
                    .Include(d => d.Intentos); // Trae también los intentos

                if (deportistaId.HasValue)
                {
                    query = query.Where(d => d.Id == deportistaId.Value);
                }

                var deportistaList = await query.ToListAsync();

                return Result<List<Deportista>>.Success(deportistaList);
            }
            catch (Exception ex)
            {
                return Result<List<Deportista>>.Failure($"Error al obtener deportistas: {ex.Message}", ErrorType.NotFound);
            }
        }

    }
}
