using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Models;
using LamiaRestTest.Repositories;
using LamiaRestTest.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LamiaRestTest.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		private readonly IDbService<Book, BookRequest> _bookService;

		public BookController(IDbService<Book, BookRequest> bookService)
		{
			this._bookService = bookService;
		}
		// GET api/<BookController>/5
		[HttpGet("{isbn}")]
		public async Task<Book> Get(string isbn)
		{
			var movie = await _bookService.Get(new BookRequest(isbn));
			return movie;
		}

	}
}
