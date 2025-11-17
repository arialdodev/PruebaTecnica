using PruebaTecnicaLlamada.Domain.SeedWork;
using System.Security.AccessControl;

namespace PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista
{
    public class Intentos : Entity
    {
        public int Arranque {  get; set; }
        public int Envion { get; set; }
        public int Total => Arranque + Envion;

        public int DeportistaId { get; set; }
        public Deportista Deportista { get; set; } = null!;
    }
}
