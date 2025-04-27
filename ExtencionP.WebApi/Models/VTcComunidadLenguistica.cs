using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcComunidadLenguistica
    {
        public int CodComunidadLenguistica { get; set; }
        public string NombreComunidad { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
