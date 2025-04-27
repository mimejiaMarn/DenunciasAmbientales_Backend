using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTmUsuariosFirma
    {
        public decimal Id { get; set; }
        public string? NitEmpleado { get; set; }
        public string? PathFirma { get; set; }
        public string? UserFea { get; set; }
        public string? PasswordFea { get; set; }
        public string? PinFea { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? IdEstado { get; set; }
    }
}
