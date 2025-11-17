namespace PruebaTecnicaLlamada.Api.Dto
{
    public class DeportistaCreateDto
    {
        public int Id { get;}
        public string Pais { get; private set; }
        public string Name { get; private set; }

        public DeportistaCreateDto(int id, string pais, string name)
        {
            Id = id;
            Pais = pais;
            Name = name;
        }

    }
}
