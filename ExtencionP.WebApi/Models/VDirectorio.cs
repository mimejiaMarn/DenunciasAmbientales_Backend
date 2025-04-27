using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VDirectorio
    {
        public string? CodigoEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string Departamento { get; set; } = null!;
        public string? Email { get; set; }
        public string? Extension { get; set; }
    }
}
