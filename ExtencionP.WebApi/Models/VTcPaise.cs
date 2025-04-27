using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcPaise
    {
        public int CodPais { get; set; }
        public string NombreComun { get; set; } = null!;
        public string NombreIso { get; set; } = null!;
        public string CodigoAlfa2 { get; set; } = null!;
        public string CodigoAlfa3 { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
