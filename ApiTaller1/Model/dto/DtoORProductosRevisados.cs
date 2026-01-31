namespace ApiTaller1.Model.dto
{
    public class DtoORProductosRevisados
    {

        public int IdOR { get; set; }

        public string NumOrdenRecibo { get; set; } = null!;

        public string CodigoCedis { get; set; } = null!;

        public string Cedis { get; set; } = null!;

        public string RucProveedor { get; set; } = null!;

        public string Proveedor { get; set; } = null!;

        public string? DescripcionProducto { get; set; }

        public string? SkuProducto { get; set; }

        public string? Ubicacion { get; set; }

        public int? UxC { get; set; }

        public int? PalletsPeq { get; set; }

        public int? PalletsGran { get; set; }

        public int? CantidadRevisada { get; set; }

        public int? CantidadCompra { get; set; }

        public DateTime? FechaFabricacion { get; set; }

        public DateTime? FechaVencimiento { get; set; }



        public int? HoraInicio { get; set; }

        public int? MinutoInicio { get; set; }

        public int? HoraFin { get; set; }

        public int? MinutoFin { get; set; }

        public DateTime? FechaLiberacion { get; set; }

        public string? LiberadoPor { get; set; }

        public string? NumeroFactura { get; set; }


    }
}
