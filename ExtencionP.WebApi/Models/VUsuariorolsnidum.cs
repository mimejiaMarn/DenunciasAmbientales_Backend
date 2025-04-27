using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VUsuariorolsnidum
    {
        public int Idusuario { get; set; }
        public byte Idrol { get; set; }
        public byte Idsistema { get; set; }
        public bool? MantenimientoAnual { get; set; }
        public string? MantAnualUsuarioIngreso { get; set; }
        public DateTime? MantAnualFechaIngreso { get; set; }
        public bool? TempRol { get; set; }
    }
}
