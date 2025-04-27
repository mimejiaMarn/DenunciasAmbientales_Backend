using ExtencionP.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using ExtencionP.WebApi.Helpers;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using ExtencionP.WebApi.Models.Formularios;

namespace ExtencionP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ModelContext _context;
        private readonly JwtHelper _jwtHelper;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public UsuarioController(ModelContext context, JwtHelper jwtHelper, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _jwtHelper = jwtHelper;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Datos de Inicio de sesión inválidos");
            }

            // Es un usuario interno, buscar en UsuariosNida
            string username = model.CorreoElectronico;
            string password = model.PassCorreo;

            // Buscar al usuario por su nombre de usuario
            VUsuariosnidum usuario = await _context.VUsuariosnida.FirstOrDefaultAsync(u => u.Nombreusuario == username);

            // Verifica si el usuario existe y su contraseña coincide
            if (usuario == null)
            {
                //return Ok(new { name = false, pass = false, idusuario = (int?)null });
                return BadRequest("Datos de inicio de sesión inválidos");
            }

            string hashedPassword = CalculateMD5Hash(password);
            bool passwordMatches = await _context.VUsuariosnida
                .AnyAsync(u => u.Nombreusuario == username && u.Clave == hashedPassword);

            if (!passwordMatches)
            {
                return BadRequest("Datos de inicio de sesión inválidos");
            }

            // Obtener la lista de roles del usuario
            var roles = await _context.VUsuariosAplicaciones
                .Where(u => u.Usuario == username && u.IdSistema == 63)
                .Select(u => u.Rol)
                .ToListAsync();

            // Verificar si el usuario tiene al menos un rol
            if (roles.Count <= 0)
            {
                return BadRequest("El usuario no tiene roles asignados");
            }

            // Generar token de acceso utilizando JwtHelper para usuarios internos
            var token = _jwtHelper.GenerateAccessToken(usuario);

            return Ok(new { name = model.CorreoElectronico, pass = true, idusuario = usuario.Idusuario, nit = usuario.Nit, roles, token });

        }

        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
