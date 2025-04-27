using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class VTmEmpleado
    {
        public string CodigoEmpleado { get; set; } = null!;
        public byte? CodigoUltgrado { get; set; }
        public byte? CodigoPuesto { get; set; }
        public string? CodigoProfesion { get; set; }
        public int? CodigoUnidadAdministrativa { get; set; }
        public int? CodigoComision { get; set; }
        public byte? DeptoAsignado { get; set; }
        public byte? MunicipioAsignado { get; set; }
        public string? CuentaBancaria { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? TercerNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? TercerApellido { get; set; }
        public int? NoEmpadronamiento { get; set; }
        public byte[]? Fotografia3 { get; set; }
        public string? NoOrden { get; set; }
        public int? NoRegistro { get; set; }
        public string? DireccionCasa { get; set; }
        public byte? Zona { get; set; }
        public byte? DeptoDireccion { get; set; }
        public byte? MunicipioDireccion { get; set; }
        public string? TelefonoCasa { get; set; }
        public string? TelefonoCelular { get; set; }
        public string? Sexo { get; set; }
        public string? NumeroIgss { get; set; }
        public DateTime? FechaNac { get; set; }
        public byte? DeptoNacimiento { get; set; }
        public byte? MunicipioNacimiento { get; set; }
        public string? EstadoCivil { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string? Estatus { get; set; }
        public string? PartidaCompleta { get; set; }
        public string? NoPartida { get; set; }
        public int? Dependencia { get; set; }
        public string? Observaciones { get; set; }
        public string? TipoCalculo { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? BonoAntiguedad { get; set; }
        public decimal? BonoProfesional { get; set; }
        public string? NoColegiado { get; set; }
        public byte? CodigoNivel { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string? Renglon { get; set; }
        public byte? CodigoBanco { get; set; }
        public string? NumeroContrato { get; set; }
        public decimal? Bono662000 { get; set; }
        public decimal? BonoSecretaria { get; set; }
        public decimal? BonoMarn { get; set; }
        public decimal? BonoCompPersonal { get; set; }
        public int? CodigoUnidadPartida { get; set; }
        public string? EstudiosActuales { get; set; }
        public decimal? GastosRepresentacion { get; set; }
        public string? Etnia { get; set; }
        public string? DireccionElectronica { get; set; }
        public string? Extension { get; set; }
        public byte? NumeroHijos { get; set; }
        public string? EdadHijos { get; set; }
        public string? InformacionFamiliares { get; set; }
        public byte? PuestoOnsec { get; set; }
        public byte? CodigoNmedio { get; set; }
        public DateTime? ColegiadoVigente { get; set; }
        public byte? Programa { get; set; }
        public string? NumeroProbidad { get; set; }
        public bool? Categoria { get; set; }
        public byte? CodigoUniversidad { get; set; }
        public int? CodigoEvaluacion { get; set; }
        public byte? DeptoCedula { get; set; }
        public byte? MunicipioCedula { get; set; }
        public string? Dpi { get; set; }
        public byte? CodigoColegio { get; set; }
        public string? UsuarioDb { get; set; }
        public string? DireccionElectronicaPersonal { get; set; }
        public byte? CodigoUniversidadUltimogrado { get; set; }
        public byte? CodigoUniversidadMaestria { get; set; }
        public byte? CodigoMaestria { get; set; }
        public byte? CodigoDoctorado { get; set; }
        public byte? CodigoUniversidadDoctorado { get; set; }
        public byte[]? Fotografia2 { get; set; }
        public string? CodigoAutorizaVac { get; set; }
        public byte[]? Fotografia { get; set; }
        public decimal? BonoSalarioMinimo { get; set; }
    }
}
