using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.ExternalData;
using LamiaRestTest.Models;
using LamiaRestTest.Requests;

namespace LamiaRestTest.Repositories
{
	public class BookRepository : IRepository<Book, IDataSource<Book, BookRequest>, BookRequest>
	{
		private IDataSource<Book, BookRequest> _dataSource;

		public BookRepository(IDataSource<Book, BookRequest> dataSource)

		{
			this._dataSource = dataSource;
		}

		public async Task<Book> Get(BookRequest request)
		{
			return await _dataSource.Get(request);
		}
	}
}
