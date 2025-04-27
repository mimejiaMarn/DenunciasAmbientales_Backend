using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcAsueto
    {
        public decimal Id { get; set; }
        public DateTime? Fecha { get; set; }
        public byte? Periodo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioIngreso { get; set; }
    }
}
