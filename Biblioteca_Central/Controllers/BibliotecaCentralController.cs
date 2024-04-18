using Biblioteca_Central.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_Central.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BibliotecaCentralController : ControllerBase
    {

        [HttpGet] 
        public async Task<ActionResult<List<Livro>>> GetAllLivros()
        {
            var livros = new List<Livro> {
                new Livro
                {
                    Id = 1,
                    Titulo = "Pride and Prejudice",
                    Autor = "Jane Austen",
                    Categoria = "Romance",
                    Valor = 50,
                    Quantidade = 50

                }
            };

            return Ok(livros);

        }

    }
}
