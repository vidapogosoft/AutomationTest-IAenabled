
namespace WorkerService1.entidades
{
    public class DTOOrdenReciboRevisada
    {
        public int IdOrdenReciboRevisada { get; set; }

        public int IdOrdenRecibo { get; set; }

        public string NumOrdenRecibo { get; set; } = null;

        public string? JsonOrder { get; set; }

        public DateTime? FechaRevision { get; set; }
    }
}
