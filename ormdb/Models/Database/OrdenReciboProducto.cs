using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class OrdenReciboProducto
{
    public int IdOrdenReciboProducto { get; set; }

    public int IdOrdenRecibo { get; set; }

    public string NumOrdenRecibo { get; set; } = null!;

    public string? DescripcionProducto { get; set; }

    public string? SkuProducto { get; set; }

    public string? Eanproducto { get; set; }

    public string? Ubicacion { get; set; }

    public int? UxC { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaFabricacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? LoteProducto { get; set; }

    public DateTime? FechaExtraccion { get; set; }

    public string? Estado { get; set; }

    public int? IdReg { get; set; }

    public string? Reg { get; set; }

    public int? CxP { get; set; }
}
