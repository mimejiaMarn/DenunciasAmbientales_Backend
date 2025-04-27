using System;
using System.Collections.Generic;

namespace ExtencionP.WebApi.Models
{
    public partial class TcPersonaJuridica
    {
        public TcPersonaJuridica()
        {
            TmDenuncia = new HashSet<TmDenuncia>();
        }

        public decimal IdPersonaJ { get; set; }
        public string? Descripcion { get; set; }
        public string? UsuarioIngreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? UsuarioActualiza { get; set; }
        public DateTime? FechaActualiza { get; set; }

        public virtual ICollection<TmDenuncia> TmDenuncia { get; set; }
    }
}
