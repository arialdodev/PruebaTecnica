using Microsoft.EntityFrameworkCore;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.Commond;
using PruebaTecnicaLlamada.Domain.SeedWork;
using PruebaTecnicaLlamada.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLlamada.Infrastructure.Repositories
{
    public class IntentosRepository : IRepository<Intentos>
    {
        public readonly PruebaTecnicaLlamadaDbContext _pruebaTecnicaLlamadaDbContext;

        public IntentosRepository(PruebaTecnicaLlamadaDbContext pruebaTecnicaLlamadaDbContext)
        {
            _pruebaTecnicaLlamadaDbContext = pruebaTecnicaLlamadaDbContext;
        }

        public async Task<Result<bool>> Create(Intentos entity)
        {
            await _pruebaTecnicaLlamadaDbContext.Intentos.AddAsync(entity);
            await _pruebaTecnicaLlamadaDbContext.SaveChangesAsync();
            return Result<bool>.Success(true);
        }

        public async Task<Result<List<Intentos>>> GetAll(int? deportistaId)
        {
            try
            {
                IQueryable<Intentos> query = _pruebaTecnicaLlamadaDbContext.Intentos
                    .Include(d => d.Id);

                if (deportistaId.HasValue)
                {
                    query = query.Where(d => d.Id == deportistaId.Value);
                }

                var deportistaList = await query.ToListAsync();

                return Result<List<Intentos>>.Success(deportistaList);
            }
            catch (Exception ex)
            {
                return Result<List<Intentos>>.Failure($"Error al obtener deportistas: {ex.Message}", ErrorType.NotFound);
            }
        }
    }
}
