using MediatR;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.Commond;
using PruebaTecnicaLlamada.Domain.SeedWork;

namespace PruebaTecnicaLlamada.Api.Queries
{
    public class DeportistaGetAllListQueryHandler : IRequestHandler<DeportistaGetAllListQuery, Result<List<Deportista>>>
    {
        public readonly IRepository<Deportista> _deportistaRepository;

        public DeportistaGetAllListQueryHandler(IRepository<Deportista> deportistaRepository)
        {
            _deportistaRepository = deportistaRepository;
        }
        public Task<Result<List<Deportista>>> Handle(DeportistaGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourcesList = _deportistaRepository.GetAll(request.DeportistaId);

            return resourcesList;
        }
    }
}
