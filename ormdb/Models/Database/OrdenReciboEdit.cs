using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class OrdenReciboEdit
{
    public int IdOrdenReciboEdit { get; set; }

    public int? IdOrdenReciboRevisada { get; set; }

    public int IdOrdenRecibo { get; set; }

    public string NumOrdenRecibo { get; set; } = null!;

    public string? JsonOrder { get; set; }

    public string? GestionadoPor { get; set; }

    public DateTime? FechaRevision { get; set; }

    public string? Estado { get; set; }

    public int? HoraFin { get; set; }

    public int? MinutoFin { get; set; }

    public string? Procesada { get; set; }

    public DateTime? FechaSync { get; set; }

    public int? IdReg { get; set; }

    public string? Reg { get; set; }
}
