using MediatR;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.SeedWork;

namespace PruebaTecnicaLlamada.Api.Queries
{
    public class DeportistaGetAllListQueryHandler : IRequestHandler<DeportistaGetAllListQuery, List<Deportista>>
    {
        public readonly IRepository<Deportista> _deportistaRepository;
        public readonly ILogger<Deportista> _logger;

        public DeportistaGetAllListQueryHandler(IRepository<Deportista> deportistaRepository, ILogger<Deportista> logger)
        {
            _deportistaRepository = deportistaRepository;
            _logger = logger;
        }
        public Task<List<Deportista>> Handle(DeportistaGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourcesList = _deportistaRepository.GetAll(request.DeportistaId);
            return resourcesList;
        }
    }
}
