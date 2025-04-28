namespace ExtencionP.WebApi.Models.Formularios
{
    public class CrearDenunciaDto
    {
        // Datos del denunciante
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int? Sexo { get; set; }
        public int? Edad { get; set; }
        public int? Etnia { get; set; }
        public int? ComunidadLinguistica { get; set; } // Idioma
        public string? DpiDenunciante { get; set; }
        public string? TelefonoDenunciante { get; set; }
        public string? DireccionDenunciante { get; set; }
        public int? IdMunicipioDenunciante { get; set; }
        public int? IdDepartamentoDenunciante { get; set; }
        public string? CorreoDenunciante { get; set; }

        // Datos del denunciado (persona o empresa)
        public bool EsPersonaIndividual { get; set; }
        public string? Empresa { get; set; }
        public string? PrimerNombreDdo { get; set; }
        public string? SegundoNombreDdo { get; set; }
        public string? PrimerApellidoDdo { get; set; }
        public string? SegundoApellidoDdo { get; set; }
        public string? DpiDdo { get; set; }
        public string? TelefonoDdo { get; set; }
        public string? DireccionDdo { get; set; } // ✅ obligatorio
        public string? ReferenciaDireccionDdo { get; set; }
        public int? IdMunicipioDdo { get; set; } // ✅ obligatorio
        public int? IdDepartamentoDdo { get; set; } // ✅ obligatorio
        public string? CorreoDdo { get; set; }

        public int? SexoDdo { get; set; }
        public int? ComunidadDdo { get; set; }
        public int? EtniaDdo { get; set; }

        // Denuncia
        public string? Asunto { get; set; } // ✅ obligatorio
        public int? IdTipoDenuncia { get; set; } // ✅ obligatorio
        //public int? IdCalificacion { get; set; }
        public string? Otros { get; set; } // Solo obligatorio si IdTipoDenuncia == 6
        public bool Terminos { get; set; } // ✅ obligatorio

        // Metadatos del expediente
        public int? PeriodoDenuncia { get; set; }
        public string? NoExpediente { get; set; }
        public int? IdExpediente { get; set; }
        public int? PeriodoExpediente { get; set; }

        // Otras opciones
        public bool EsAnonima { get; set; }
    }
}
