using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class TransactionActionsOrder
{
    public int IdTransactionActionsOrder { get; set; }

    public int? IdTran { get; set; }

    public string? Tabla { get; set; }

    public string? Accion { get; set; }

    public string? DatoAccion1 { get; set; }

    public string? DatoAccion2 { get; set; }

    public string? DatoAccion3 { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? UsuarioIngreso { get; set; }

    public string? Estado { get; set; }

    public string? DatoAccion4 { get; set; }

    public string? DatoAccion5 { get; set; }

    public string? DatoAccion6 { get; set; }

    public string? DatoAccion7 { get; set; }

    public string? DatoAccion8 { get; set; }
}
