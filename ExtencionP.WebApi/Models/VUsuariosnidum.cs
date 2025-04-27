using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VUsuariosnidum
    {
        public int Idusuario { get; set; }
        public string Nombreusuario { get; set; } = null!;
        public byte? Idrol { get; set; }
        public byte? Idsistema { get; set; }
        public string? Nit { get; set; }
        public string Clave { get; set; } = null!;
        public string? Nombre { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public bool? Cambiarclave { get; set; }
        public bool? Bloqueado { get; set; }
        public string? Firma { get; set; }
        public DateTime? UltimoCambioClave { get; set; }
        public bool FirmaElectronica { get; set; }
        public bool? DirectorGestion { get; set; }
        public string? UsernameFea { get; set; }
        public string? PasswordFea { get; set; }
        public string? ClaveFea { get; set; }
        public string? PinFea { get; set; }
        public bool? VersionFea { get; set; }
        public string? UsuarioFea { get; set; }
        public string? CodigoVerificacion { get; set; }
        public decimal? EstadoCodigo { get; set; }
    }
}
