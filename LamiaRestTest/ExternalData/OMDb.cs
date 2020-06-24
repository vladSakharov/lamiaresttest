using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LamiaRestTest.Models;
using LamiaRestTest.Repositories;

namespace LamiaRestTest.ExternalData
{
	public class OMDb : IDataSource<Movie, MovieRequest>
	{
		public async Task<Movie> Get(MovieRequest request)
		{
			Movie movie = await RequestMovie(request.Title, request.Year, request.Version);
			return movie;
		}

		private async Task<Movie> RequestMovie(string title, int year, string plotVersion)
		{
			string apiKey = "3f104680";
			string baseUri = $"http://www.omdbapi.com/?";

			var sb = new StringBuilder(baseUri);
			sb.Append($"t={title}");
			sb.Append($"&y={year}");
			sb.Append($"&plot={plotVersion}");
			sb.Append($"&apikey={apiKey}");

			string result = string.Empty;
			HttpClient client = new HttpClient();
			var response = await client.GetAsync(sb.ToString());

			if (response.IsSuccessStatusCode == false)
			{
				return default(Movie);
			}
			string json = await response.Content.ReadAsStringAsync();

			if (json.ToLower().Contains("error")) 
			{
				return default(Movie);
			}

			return JsonSerializer.Deserialize<Movie>(json);
		}
	}
}
