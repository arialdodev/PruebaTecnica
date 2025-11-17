using MediatR;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.SeedWork;

namespace PruebaTecnicaLlamada.Api.Commands
{
    public class DeportistaCreateCommandHandler : IRequestHandler<DeportistaCreateCommand, bool>
    {
        public readonly IRepository<Deportista> _deportistaRepository;
        public readonly ILogger<Deportista> _logger;

        public DeportistaCreateCommandHandler(IRepository<Deportista> deportistaRepository, ILogger<Deportista> logger)
        {
            _deportistaRepository = deportistaRepository;
            _logger = logger;
        }

        public async Task<bool> Handle(DeportistaCreateCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("📝 Recibido comando para crear ResourceType: {TypeName}", request.DeportistaCreateDto.Name);

            var entity = new Deportista(request.DeportistaCreateDto.Pais, request.DeportistaCreateDto.Name);

            _logger.LogError("se daño");

            return await _deportistaRepository.Create(entity);
        }
    }
}
