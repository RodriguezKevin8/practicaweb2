using System;
using System.Collections.Generic;

namespace practicaweb2.Models;

public partial class TipoEquipo
{
    public int IdTipoEquipo { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }
}
