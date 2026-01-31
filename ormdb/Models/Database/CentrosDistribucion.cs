using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class CentrosDistribucion
{
    public int IdCentro { get; set; }

    public string? CodCentro { get; set; }

    public string? Centro { get; set; }

    public int? IdRegion { get; set; }

    public string? Region { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
