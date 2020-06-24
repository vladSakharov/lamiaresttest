using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LamiaRestTest.Models;
using LamiaRestTest.Requests;

namespace LamiaRestTest.ExternalData
{
	public class OpenLibrary : IDataSource<Book, BookRequest>
	{
		public async Task<Book> Get(BookRequest request)
		{
			return await RequestBook(request.ISBN);
		}

		private async Task<Book> RequestBook(string isbn)
		{
			string baseUri = $"http://openlibrary.org/api/volumes/brief";

			string type = "isbn";
			var sb = new StringBuilder(baseUri);
			sb.Append($"/{type}");
			sb.Append($"/{isbn}");
			sb.Append($".json");

			string result = string.Empty;
			HttpClient client = new HttpClient();
			var response = await client.GetAsync(sb.ToString());

			if (response.IsSuccessStatusCode == false)
			{
				return default(Book);
			}

			if (response.Content.Headers.ContentLength == 2)
			{
				return default(Book);
			}

			string json = await response.Content.ReadAsStringAsync();


			return JsonSerializer.Deserialize<Book>(json);
		}
	}
}
