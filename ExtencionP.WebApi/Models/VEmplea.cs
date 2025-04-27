using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VEmplea
    {
        public string? Dpi { get; set; }
        public string? CodigoEmpleado { get; set; }
        public string? Nombre { get; set; }
        public int? CodigoUnidadAdministrativa { get; set; }
        public string? Extension { get; set; }
        public string Departamento { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public byte? CodigoPuesto { get; set; }
        public string? Renglon { get; set; }
        public string? Sexo { get; set; }
        public string? DireccionElectronica { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaNac { get; set; }
        public int? CodigoEvaluacion { get; set; }
        public decimal? Sueldo { get; set; }
        public string? Estatus { get; set; }
        public decimal? Edad { get; set; }
        public string? Emailpersonal { get; set; }
        public string? Celular { get; set; }
    }
}
