using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcDepartamentosPg
    {
        public int CodigoDepartamento { get; set; }
        public string NombreDepartamento { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public byte? CodigoRegion { get; set; }
    }
}
