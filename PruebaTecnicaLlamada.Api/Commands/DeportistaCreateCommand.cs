using MediatR;
using PruebaTecnicaLlamada.Api.Dto;
using PruebaTecnicaLlamada.Domain.Commond;

namespace PruebaTecnicaLlamada.Api.Commands
{
    public class DeportistaCreateCommand : IRequest<Result<bool>>
    {
        public DeportistaCreateDto DeportistaCreateDto { get; private set; }

        public DeportistaCreateCommand(DeportistaCreateDto deportistaCreateDto)
        {
            DeportistaCreateDto = deportistaCreateDto;
        }
    }
}
