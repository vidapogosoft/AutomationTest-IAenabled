using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class OrdenReciboRevisada
{
    public int IdOrdenReciboRevisada { get; set; }

    public int IdOrdenRecibo { get; set; }

    public string NumOrdenRecibo { get; set; } = null!;

    public string CodigoCedis { get; set; } = null!;

    public string Cedis { get; set; } = null!;

    public string RucProveedor { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public string? JsonOrder { get; set; }

    public string? GestionadoPor { get; set; }

    public DateTime? FechaRevision { get; set; }

    public string? Estado { get; set; }

    public int? HoraInicio { get; set; }

    public int? MinutoInicio { get; set; }

    public int? HoraFin { get; set; }

    public int? MinutoFin { get; set; }

    public string? JsonNovedades { get; set; }

    public string? Procesada { get; set; }

    public DateTime? FechaSync { get; set; }

    public DateTime? FechaLiberacion { get; set; }

    public string? LiberadoPor { get; set; }

    public string? NumeroFactura { get; set; }

    public string? JsonInspecciones { get; set; }

    public int? IdReg { get; set; }

    public string? Reg { get; set; }

    public string? JsonHoraInicio { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public string? RechazadoPor { get; set; }

    public string? ComentarioRechazo { get; set; }
}
