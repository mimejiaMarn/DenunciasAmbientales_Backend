using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExtencionP.WebApi.Models.Formularios;
using ExtencionP.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExtencionP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenunciasController : ControllerBase
    {
        private readonly ModelContext _context;

        public DenunciasController(ModelContext context)
        {
            _context = context;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearDenuncia([FromBody] CrearDenunciaDto dto)
        {
            try
            {
                var fechaActual = DateTime.Now;
                var periodoActual = fechaActual.Year;

                // Generar nuevo ID_SICODA
                decimal nuevoIdSicoda = await _context.TmDenuncias.AnyAsync()
                    ? await _context.TmDenuncias.MaxAsync(d => d.IdSicoda) + 1
                    : 1;

                // Generar nuevo ID_DENUNCIA para el año actual
                var denunciasPeriodo = _context.TmDenuncias
                    .Where(d => d.PeriodoDenuncia == periodoActual);

                decimal nuevoIdDenuncia = await denunciasPeriodo.AnyAsync()
                    ? (await denunciasPeriodo.MaxAsync(d => d.IdDenuncia))!.Value + 1
                    : 1;

                // Generar número de denuncia
                string numeroFormateado = nuevoIdDenuncia.ToString().PadLeft(4, '0');
                string noDenuncia = $"D-E-{numeroFormateado}-{periodoActual}";

                // Conversión segura de teléfonos
                decimal? telefonoDenunciante = null;
                if (!string.IsNullOrWhiteSpace(dto.TelefonoDenunciante))
                {
                    if (decimal.TryParse(dto.TelefonoDenunciante, out var tmpTel))
                        telefonoDenunciante = tmpTel;
                }

                decimal? telefonoDdo = null;
                if (!string.IsNullOrWhiteSpace(dto.TelefonoDdo))
                {
                    if (decimal.TryParse(dto.TelefonoDdo, out var tmpTelDdo))
                        telefonoDdo = tmpTelDdo;
                }

                var denuncia = new TmDenuncia
                {
                    // Datos de ID
                    IdSicoda = nuevoIdSicoda,
                    IdDenuncia = nuevoIdDenuncia,
                    PeriodoDenuncia = periodoActual,

                    // Datos Denunciante
                    PrimerNombre = dto.PrimerNombre,
                    SegundoNombre = dto.SegundoNombre,
                    PrimerApellido = dto.PrimerApellido,
                    SegundoApellido = dto.SegundoApellido,
                    Sexo = dto.Sexo,
                    Edad = dto.Edad,
                    Etnia = dto.Etnia,
                    ComunidadLinguistica = dto.ComunidadLinguistica,
                    DpiDenunciante = dto.DpiDenunciante,
                    TelefonoDenunciante = telefonoDenunciante,
                    DireccionDenunciante = dto.DireccionDenunciante,
                    IdMunicipioDenunciante = dto.IdMunicipioDenunciante,
                    IdDepartamentoDenunciante = dto.IdDepartamentoDenunciante,
                    CorreoDenunciante = dto.CorreoDenunciante,

                    // Datos Denunciado
                    EmpresaDdo = dto.Empresa,
                    PrimerNombreDdo = dto.PrimerNombreDdo,
                    SegundoNombreDdo = dto.SegundoNombreDdo,
                    PrimerApellidoDdo = dto.PrimerApellidoDdo,
                    SegundoApellidoDdo = dto.SegundoApellidoDdo,
                    DpiDdo = dto.DpiDdo,
                    TelefonoDdo = telefonoDdo,
                    DireccionDdo = dto.DireccionDdo,
                    ReferenciaDireccionDdo = dto.ReferenciaDireccionDdo,
                    IdMunicipioDdo = dto.IdMunicipioDdo,
                    IdDepartamentoDdo = dto.IdDepartamentoDdo,
                    CorreoDdo = dto.CorreoDdo,
                    SexoDdo = dto.SexoDdo,
                    ComunidadDdo = dto.ComunidadDdo,
                    EtniaDdo = dto.EtniaDdo,

                    // Otros Datos
                    Asunto = dto.Asunto,
                    IdTipoDenuncia = dto.IdTipoDenuncia,
                    Otros = dto.Otros,
                    Terminos = dto.Terminos ? 1 : 2,
                    IdPersona = dto.EsPersonaIndividual ? 2 : 1,
                    IdAnonima = dto.EsAnonima ? 2 : 1,
                    FechaIngreso = DateTime.Now,
                    UsuarioIngreso = string.IsNullOrWhiteSpace(dto.CorreoDenunciante) ? "PUBLICO" : dto.CorreoDenunciante,
                    NoDenuncia = noDenuncia,
                    IdEstatusDenu = 1, // Estado Inicial de Ingreso
                    //IdCalificacion = dto.IdCalificacion
                };

                _context.TmDenuncias.Add(denuncia);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    mensaje = "Denuncia guardada con éxito",
                    noDenuncia,
                    idDenuncia = denuncia.IdSicoda  // Asegúrate que devuelves el ID real para poder usarlo
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensaje = "Ocurrió un error al guardar la denuncia.",
                    detalle = ex.Message
                });
            }
        }

        [HttpPost("calificar")]
        public async Task<IActionResult> CalificarDenuncia([FromBody] CalificarDenunciaDto dto)
        {
            var denuncia = await _context.TmDenuncias.FirstOrDefaultAsync(d => d.IdSicoda == dto.IdDenuncia);

            if (denuncia == null)
                return NotFound();

            denuncia.IdCalificacion = dto.IdCalificacion;
            denuncia.FechaActualiza = DateTime.Now;
            denuncia.UsuarioActualiza = "PUBLICO";

            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Calificación registrada exitosamente" });
        }

        // DenunciasController.cs
        [HttpGet("estado/{noDenuncia}")]
        public async Task<IActionResult> ObtenerEstadoDenuncia(string noDenuncia)
        {
            if (string.IsNullOrWhiteSpace(noDenuncia))
                return BadRequest(new { mensaje = "Número de denuncia inválido." });

            var denuncia = await _context.TmDenuncias
                .Where(d => d.NoDenuncia == noDenuncia)
                .Select(d => new { estado = d.IdEstatusDenu })
                .FirstOrDefaultAsync();

            if (denuncia == null)
                return NotFound(new { mensaje = "Denuncia no encontrada." });

            return Ok(denuncia);
        }


    }
}
