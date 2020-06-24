using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.ExternalData;
using LamiaRestTest.Models;
using LamiaRestTest.Requests;

namespace LamiaRestTest.Repositories
{
	public class BookService : IDbService<Book, BookRequest>
	{

		private readonly IRepository<Book, IDataSource<Book, BookRequest>, BookRequest> _bookRepository;

		public BookService(IRepository<Book, IDataSource<Book, BookRequest>, BookRequest> bookRepository)
		{
			this._bookRepository = bookRepository;
		}
		public async Task<Book> Get(BookRequest request)
		{
			return await _bookRepository.Get(request);
		}
	}
}
