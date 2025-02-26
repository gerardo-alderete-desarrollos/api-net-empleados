using System;
using System.Collections.Generic;

namespace WebApiPruebReact.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Contrasena { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? UrlFoto { get; set; }
}
