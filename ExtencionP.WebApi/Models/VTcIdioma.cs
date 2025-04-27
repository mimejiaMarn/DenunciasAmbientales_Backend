using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcIdioma
    {
        public byte CodigoIdioma { get; set; }
        public string Descripcion { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string UsuarioActualizacion { get; set; } = null!;
        public DateTime FechaActualizacion { get; set; }
    }
}
