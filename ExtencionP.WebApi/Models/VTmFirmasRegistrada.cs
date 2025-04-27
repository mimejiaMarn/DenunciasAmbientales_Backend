using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTmFirmasRegistrada
    {
        public decimal Id { get; set; }
        public string? PatchArchivo { get; set; }
        public string? EstadoRecibido { get; set; }
        public string? UsuarioFirma { get; set; }
        public DateTime? FechaFirma { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
