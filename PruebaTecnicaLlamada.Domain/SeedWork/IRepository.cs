
using PruebaTecnicaLlamada.Domain.Commond;

namespace PruebaTecnicaLlamada.Domain.SeedWork
{
    public interface IRepository<T> where T : class
    {
        Task<Result<bool>> Create(T entity);
        Task<Result<List<T>>> GetAll(int? deportistaId);
    }
}
