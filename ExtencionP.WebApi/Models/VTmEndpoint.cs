using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTmEndpoint
    {
        public decimal Id { get; set; }
        public string? Endpoint { get; set; }
        public string? Descripcion { get; set; }
        public string? Tipo { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? IdEstado { get; set; }
    }
}
