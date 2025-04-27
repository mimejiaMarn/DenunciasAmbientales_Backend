using Microsoft.AspNetCore.Http;
using ExtencionP.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExtencionP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilidadesController : ControllerBase
    {
        private readonly ModelContext _context;

        public UtilidadesController(ModelContext context)
        {
            _context = context;
        }

        // Endpoint: /api/utilidades/departamentos
        [HttpGet("departamentos")]
        public async Task<IActionResult> GetDepartamentos()
        {
            var departamentos = await _context.VTcDepartamentos1
                .OrderBy(d=> d.CodDepartamento)
                .Select(d => new
                {
                    label = d.NombreDepartamento,
                    value = d.CodDepartamento
                })
                .ToListAsync();

            return Ok(departamentos);
        }

        // Endpoint: /api/utilidades/municipios/1
        [HttpGet("municipios/{idDepartamento}")]
        public async Task<IActionResult> GetMunicipiosByDepartamento(int idDepartamento)
        {
            var municipios = await _context.VTcMunicipios1
                .Where(m => m.CodDepartamento == idDepartamento)
                .OrderBy(m => m.CodDepartamento)
                .Select(m => new
                {
                    label = m.NombreMunicipio,
                    value = m.CodMunicipio
                })
                .ToListAsync();

            return Ok(municipios);
        }

        [HttpGet("sexos")]
        public async Task<IActionResult> GetSexos()
        {
            var sexos = await _context.VTcSexos
                .Select(s => new
                {
                    label = s.NombreSexo,
                    value = s.CodSexo
                })
                .ToListAsync();

            return Ok(sexos);
        }
        // Endpoint: /api/utilidades/idiomas
        [HttpGet("idiomas")]
        public async Task<IActionResult> GetIdiomas()
        {
            var idiomas = await _context.VTcComunidadLenguisticas
                .OrderBy(i => i.NombreComunidad)
                .Select(i => new
                {
                    label = i.NombreComunidad,
                    value = i.CodComunidadLenguistica
                })
                .ToListAsync();

            return Ok(idiomas);
        }

        // Endpoint: /api/utilidades/etnias
        [HttpGet("etnias")]
        public async Task<IActionResult> GetEtnias()
        {
            var etnias = await _context.VTcPueblos
                .OrderBy(e => e.NombrePueblo)
                .Select(e => new
                {
                    label = e.NombrePueblo,
                    value = e.CodPueblo
                })
                .ToListAsync();

            return Ok(etnias);
        }

        // GET: /api/utilidades/tipos-denuncia
        [HttpGet("tipo-denuncias")]
        public async Task<IActionResult> GetTipoDenuncias()
        {
            var tipos = await _context.TcTipoDenuncia
                .OrderBy(t => t.IdTipoDenuncia)
                .Select(t => new {
                    label = t.Descripcion,
                    value = t.IdTipoDenuncia
                }).ToListAsync();

            return Ok(tipos);
        }

    }
}
