using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcPai
    {
        public byte Grupo { get; set; }
        public byte Prefijo { get; set; }
        public string Pais { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string UsuarioActualizacion { get; set; } = null!;
        public DateTime FechaActualizacion { get; set; }
    }
}
