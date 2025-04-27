using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTmParametro
    {
        public decimal Id { get; set; }
        public string? Env { get; set; }
        public string? Format { get; set; }
        public string? BillingUsername { get; set; }
        public string? BillingPassword { get; set; }
        public string? ImgSize { get; set; }
        public string? Position { get; set; }
        public decimal? Npage { get; set; }
        public string? Location { get; set; }
        public string? Url { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? IdEstado { get; set; }
    }
}
