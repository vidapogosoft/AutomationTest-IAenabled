using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string RucProveedor { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public DateTime? FechaExtraccion { get; set; }

    public string? Estado { get; set; }
}
