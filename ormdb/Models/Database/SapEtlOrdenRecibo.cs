using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class SapEtlOrdenRecibo
{
    public int IdSecuencial { get; set; }

    public string OrdenCompra { get; set; } = null!;

    public DateTime FechaOrden { get; set; }

    public string CodigoCentro { get; set; } = null!;

    public string Centro { get; set; } = null!;

    public string CodProveedor { get; set; } = null!;

    public string RucProveedor { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public string? DescripcionProducto { get; set; }

    public string? SkuProducto { get; set; }

    public string? Eanproducto { get; set; }

    public string? Ubicacion { get; set; }

    public int? UxC { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaExtraccion { get; set; }
}
