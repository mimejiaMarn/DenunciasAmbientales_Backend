using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class TmDenuncia
    {
        public decimal IdSicoda { get; set; }
        public decimal? IdDenuncia { get; set; }
        public decimal? PeriodoDenuncia { get; set; }
        public decimal? IdExpediente { get; set; }
        public decimal? PeriodoExpediente { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public decimal? Sexo { get; set; }
        public decimal? Edad { get; set; }
        public decimal? Etnia { get; set; }
        public decimal? ComunidadLinguistica { get; set; }
        public decimal? FormaIngreso { get; set; }
        public string? Token { get; set; }
        public DateTime? FechaToken { get; set; }
        public string? DpiDenunciante { get; set; }
        public decimal? TelefonoDenunciante { get; set; }
        public string? DireccionDenunciante { get; set; }
        public decimal? IdMunicipioDenunciante { get; set; }
        public decimal? IdDepartamentoDenunciante { get; set; }
        public string? CorreoDenunciante { get; set; }
        public string? PrimerNombreDdo { get; set; }
        public string? SegundoNombreDdo { get; set; }
        public string? PrimerApellidoDdo { get; set; }
        public string? SegundoApellidoDdo { get; set; }
        public string? DpiDdo { get; set; }
        public decimal? TelefonoDdo { get; set; }
        public string? DireccionDdo { get; set; }
        public string? ReferenciaDireccionDdo { get; set; }
        public decimal? IdMunicipioDdo { get; set; }
        public decimal? IdDepartamentoDdo { get; set; }
        public string? CorreoDdo { get; set; }
        public string? EmpresaDdo { get; set; }
        public decimal? SexoDdo { get; set; }
        public decimal? ComunidadDdo { get; set; }
        public decimal? EtniaDdo { get; set; }
        public string? Asunto { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public decimal? IdEstatusDenu { get; set; }
        public string? NoExpediente { get; set; }
        public string? NoDenuncia { get; set; }
        public decimal? IdTipoDenuncia { get; set; }
        public string? Otros { get; set; }
        public decimal? IdPersona { get; set; }
        public decimal? IdAnonima { get; set; }
        public string? MotivoDenegacion { get; set; }
        public decimal? Terminos { get; set; }
        public decimal? IdCalificacion { get; set; }

        public virtual TcAnonima? IdAnonimaNavigation { get; set; }
        public virtual TcCalificacion? IdCalificacionNavigation { get; set; }
        public virtual TcEstatusDenuncium? IdEstatusDenuNavigation { get; set; }
        public virtual TcPersonaJuridica? IdPersonaNavigation { get; set; }
        public virtual TcTipoDenuncium? IdTipoDenunciaNavigation { get; set; }
        public virtual TcTermino? TerminosNavigation { get; set; }
    }
}
