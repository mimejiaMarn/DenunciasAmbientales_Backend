using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VRolsnidum
    {
        public byte Idrol { get; set; }
        public byte Idsistema { get; set; }
        public string? Descripcionrol { get; set; }
        public string Nombrerol { get; set; } = null!;
    }
}
