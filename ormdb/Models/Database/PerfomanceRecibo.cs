using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class PerfomanceRecibo
{
    public int IdPerfomanceRecibo { get; set; }

    public int? IdRegion { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? HorasRecibo { get; set; }

    public int? PalletsPeq { get; set; }

    public int? PalletsGran { get; set; }

    public int? TotalPallets { get; set; }

    public int? PalletsPorHora { get; set; }
}
