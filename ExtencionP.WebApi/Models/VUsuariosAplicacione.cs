using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VUsuariosAplicacione
    {
        public int? CodigoUnidadAdministrativa { get; set; }
        public string UnidadAdministrativa { get; set; } = null!;
        public byte IdSistema { get; set; }
        public string? NombreSistema { get; set; }
        public string? CodigoEmpleado { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; } = null!;
        public string? NombreCompleto { get; set; }
        public byte IdRol { get; set; }
        public string Rol { get; set; } = null!;
        public string? DescripcionRol { get; set; }
    }
}
