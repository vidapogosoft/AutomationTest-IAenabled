using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class OrdenRecibo
{
    public int IdOrdenRecibo { get; set; }

    public string NumOrdenRecibo { get; set; } = null!;

    public DateTime FechaOrdenRecibo { get; set; }

    public string CodigoCedis { get; set; } = null!;

    public string Cedis { get; set; } = null!;

    public string RucProveedor { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public string NumOrdenCompra { get; set; } = null!;

    public string? NumFactura { get; set; }

    public DateTime? FechaExtraccion { get; set; }

    public string? Estado { get; set; }

    public int? IdReg { get; set; }

    public string? Reg { get; set; }
}
