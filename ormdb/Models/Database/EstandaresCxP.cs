using System;
using System.Collections.Generic;

namespace ormdb.Models.Database;

public partial class EstandaresCxP
{
    public int IdCxp { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? Base { get; set; }

    public int? Altura { get; set; }

    public int? IdReg { get; set; }

    public DateTime? FechCarga { get; set; }

    public string? UsuarioCarga { get; set; }
}
