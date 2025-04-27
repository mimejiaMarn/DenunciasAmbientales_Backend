using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VFinancieroEmpleado
    {
        public string CodigoEmpleado { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Dpi { get; set; }
        public int? CodigoUnidadAdministrativa { get; set; }
        public string Departamento { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public byte? CodigoPuesto { get; set; }
        public string? Renglon { get; set; }
        public string? Sexo { get; set; }
        public string? DireccionElectronica { get; set; }
        public decimal? CodigoEvaluacion { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Edad { get; set; }
    }
}
