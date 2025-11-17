using PruebaTecnicaLlamada.Domain.SeedWork;

namespace PruebaTecnicaLlamada.Domain.AggregateModel.AggregateDeportista
{
    public class Deportista : Entity, IAggregateRoot
    {
        public string Pais { get; private set; }
        public string Name { get; private set; }

        public Deportista() { }

        public Deportista(string pais, string name) 
        {
            Pais = pais;
            Name = name;
        }
    }
}
