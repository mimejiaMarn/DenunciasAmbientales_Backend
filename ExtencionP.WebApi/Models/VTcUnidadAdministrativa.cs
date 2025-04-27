using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTcUnidadAdministrativa
    {
        public int CodigoUnidadAdministrativa { get; set; }
        public string Descripcion { get; set; } = null!;
        public string UsuarioIngreso { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string UsuarioActualizacion { get; set; } = null!;
        public DateTime FechaActualizacion { get; set; }
        public string? Programa { get; set; }
        public string? Actividad { get; set; }
        public byte? Periodo { get; set; }
        public string? Tipo { get; set; }
        public int? CodigoDepartamento { get; set; }
        public int? CodigoMunicipio { get; set; }
        public string? Pertenece { get; set; }
        public string? Hpertenece { get; set; }
        public string? Estatus { get; set; }
        public int? Region { get; set; }
    }
}
