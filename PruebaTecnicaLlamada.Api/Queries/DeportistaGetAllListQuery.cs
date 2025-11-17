using MediatR;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;
using PruebaTecnicaLlamada.Domain.Commond;

namespace PruebaTecnicaLlamada.Api.Queries
{
    public class DeportistaGetAllListQuery : IRequest<Result<List<Deportista>>>
    {
        public int? DeportistaId { get; private set; }

        public DeportistaGetAllListQuery(int? deportistaId)
        {
            DeportistaId = deportistaId;
        }
    }
}
