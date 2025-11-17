using MediatR;
using PruebaTecnicaLlamada.Api.Dto;

namespace PruebaTecnicaLlamada.Api.Commands
{
    public class DeportistaCreateCommand : IRequest<bool>
    {
        public DeportistaCreateDto DeportistaCreateDto { get; private set; }

        public DeportistaCreateCommand(DeportistaCreateDto deportistaCreateDto)
        {
            DeportistaCreateDto = deportistaCreateDto;
        }
    }
}
