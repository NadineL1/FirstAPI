using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		static private List<Book> books = new()
		{
			new Book
			{
				Id = 1,
				Title = "The Great Gatsby",
				Author = "F. Scott Fitzgerald",
				YearPublished = 1925
			},

			new Book
			{
				Id = 2,
				Title = "To Kill a Mockingbird",
				Author = "Harper Lee",
				YearPublished = 1960
			},
			new Book
			{
				Id = 3,
				Title = "1984",
				Author = "George Orwell",
				YearPublished = 1949
			},

			new Book
			{
				Id = 4,
				Title = "Pride and Prejudice",
				Author = "Jane Austen",
				YearPublished = 1813
			},


			new Book
			{
				Id = 5,
				Title = "Moby Dick",
				Author = "Herman Melville",
				YearPublished = 1851
			}
		};

		/* Creating HTTP methods */
		[HttpGet]
		public ActionResult<List<Book>> GetBooks()
		{
			return Ok(books); //everything worked, api will receive ok 200 status code and the books
		}

		// requesting specific book
		[HttpGet("{id}")]
		public ActionResult<Book> GetBookById(int id)
		{
			var book = books.FirstOrDefault(x => x.Id == id);
			if (book == null)
				return NotFound();

			return Ok(book);
		}

	}
}
