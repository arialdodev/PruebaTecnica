using MediatR;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaLlamada.Api.Commands;
using PruebaTecnicaLlamada.Api.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaLlamada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeportistaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeportistaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DeportistaCreateDto deportistaCreateDto  )
        {
            var command = new DeportistaCreateCommand(deportistaCreateDto);
            var result = await _mediator.Send(command);
            return StatusCode(200, result);
        }
    }
}
