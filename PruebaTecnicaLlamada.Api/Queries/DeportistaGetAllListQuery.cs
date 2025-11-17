using MediatR;
using PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista;

namespace PruebaTecnicaLlamada.Api.Queries
{
    public class DeportistaGetAllListQuery : IRequest<List<Deportista>>
    {
        public int? DeportistaId { get; private set; }

        public DeportistaGetAllListQuery(int? deportistaId)
        {
            DeportistaId = deportistaId;
        }
    }
}
