using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Models;
using LamiaRestTest.Repositories;

namespace LamiaRestTest.Requests
{
	public class BookRequest : IDataRequest<Book>
	{
		public BookRequest(string isbn)
		{
			this.ISBN = isbn;
		}

		public string ISBN { get; set; }
	}
}
