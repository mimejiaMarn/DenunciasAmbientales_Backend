using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcSexo
    {
        public int CodSexo { get; set; }
        public string NombreSexo { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
