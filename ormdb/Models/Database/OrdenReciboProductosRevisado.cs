using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class OrdenReciboProductosRevisado
{
    public int IdOrdenReciboProductoRevisado { get; set; }

    public int? IdOrdenReciboProducto { get; set; }

    public int? IdOrdenRecibo { get; set; }

    public string? DescripcionProducto { get; set; }

    public string? SkuProducto { get; set; }

    public string? Eanproducto { get; set; }

    public string? Ubicacion { get; set; }

    public int? UxC { get; set; }

    public int? PalletsPeq { get; set; }

    public int? PalletsGran { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaFabricacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? LoteProducto { get; set; }

    public int? CantidadRevisada { get; set; }

    public int? CantidadCompra { get; set; }

    public string? GestionadoPor { get; set; }

    public DateTime? FechaRevision { get; set; }

    public string? Estado { get; set; }

    public string? Averias { get; set; }

    public int? IdOrdenReciboRevisada { get; set; }

    public string? NumOrdenRecibo { get; set; }

    public string? CodigoCedis { get; set; }

    public string? Cedis { get; set; }

    public string? RucProveedor { get; set; }

    public string? Proveedor { get; set; }

    public int? HoraInicio { get; set; }

    public int? MinutoInicio { get; set; }

    public int? HoraFin { get; set; }

    public int? MinutoFin { get; set; }

    public DateTime? FechaLiberacion { get; set; }

    public string? LiberadoPor { get; set; }

    public string? NumeroFactura { get; set; }

    public int? IdReg { get; set; }

    public string? Reg { get; set; }

    public int? CxP { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public string? RechazadoPor { get; set; }

    public string? ComentarioRechazo { get; set; }
}
