using Bilioteca_Central.Data_Biblioteca;
using Bilioteca_Central.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bilioteca_Central.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Biblioteca_Controller : ControllerBase
    {
            private readonly Data_Context _context;

        public Biblioteca_Controller(Data_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Livro>>> GetAllLivros()
        {
            var livros = await _context.Livros.ToListAsync();

            return Ok(livros);

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Livro>> GetLivro(int id)
        {
            var Livro = await _context.Livros.FindAsync(id);
            if(Livro == null)
            {
                return BadRequest("Hero Not Found");
            }

            return Ok(Livro);
        }

        [HttpPost]

        public async Task<ActionResult<List<Livro>>> AddLivro(Livro Livro)
        {
            _context.Livros.Add(Livro);
            await _context.SaveChangesAsync();

            return Ok(await GetAllLivros());
        }

  
    }
}
