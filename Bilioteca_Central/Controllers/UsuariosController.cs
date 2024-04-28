using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bilioteca_Central.Data_Biblioteca;
using Bilioteca_Central.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca_Central.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly Data_Context _context;
        public UsuariosController(Data_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsers()
        {
            var users = await _context.Usuarios.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUser(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<Usuario>>> CreateUser(Usuario user)
        {
            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Usuario>>> UpdateUser(int id, Usuario request)
        {

            var user = await _context.Usuarios.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            request.Id = user.Id;

            _context.Entry(user).CurrentValues.SetValues(request);
            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }
    }
}
