namespace PruebaTecnicaLlamada.Api.Dto
{
    public class IntentosCreateDto
    {
        public int Arranque { get; set; }
        public int Envion { get; set; }
        public int Total => Arranque + Envion;
    }
}
