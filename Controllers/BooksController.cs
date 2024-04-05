using LibraryManagement.API.Comunication.Request;
using LibraryManagement.API.Comunication.Responses;
using LibraryManagement.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(RequestGetAllBooks), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(NotFoundResult), StatusCodes.Status404NotFound)]
    public IActionResult GetBooks()
    {
        var response = new Books
        {
            Title = "nome do livro",
            Author = "nome do autor",
            Genre = new List<string> { "ação", "aventura"},
            Price = 22,
            InStock = 3,
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBooksJson), StatusCodes.Status201Created)]
    public IActionResult CreateBooks([FromBody] RequestRegisteredBooksJson request)
    {
        var response = new ResponseRegisterBooksJson {
            Id = request.Id,
            Title = request.Title,
            Author = request.Author,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBooks([FromBody] RequestUpdateBooksJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBooks() 
    {
        return NoContent();
    }
}
