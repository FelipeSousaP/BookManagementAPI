using GerenciadorDeLivroAPI.Objects;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeLivroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static List<Livro> livros = new List<Livro>();

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            livros.Add(livro);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //Erro novo: Encontrei um metodo que me faz encontrar o id especifico
            var book = livros.FirstOrDefault(Buscar => Buscar.id == id);
            //erro 1: Caso o livro não seja encontrado
            if (book == null) { return NotFound(new { message = $"O livro da ID {id} não foi encontrado" }); }
            //Erro 2: Dentro do ok deve retorna o book
            return Ok(book);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(livros);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = livros.FirstOrDefault(Buscar => Buscar.id == id);
            // verifica se o livro exsite
            if (book == null) { return NotFound(); }
            // Permite que seja removido da lista
            livros.Remove(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] Livro Atualização)
        {
            var book = livros.FirstOrDefault(Buscar => Buscar.id == id);
            if (book == null) { return NotFound(); }
            // aprendizado: quando quero atualizar uma variavel dentro de uma classe.
            // Colocar o string.IsNullOrEmpty
            book.nameDoLivro = Atualização.nameDoLivro;
            book.nomeDoAutor = Atualização.nomeDoAutor;
            book.dataDaPublicação = Atualização.dataDaPublicação;
            // aprendizado: O NoContent diz: "Deu tudo certo, processei seu pedido, mas não tenho nada para te mostrar agora"
            return Ok();
        }
    }
}
