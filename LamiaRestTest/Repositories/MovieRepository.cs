using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.ExternalData;
using LamiaRestTest.Models;

namespace LamiaRestTest.Repositories
{
	public class MovieRepository : IRepository<Movie, IDataSource<Movie, MovieRequest>, MovieRequest>
	{
		private IDataSource<Movie, MovieRequest> _dataSource;

		public MovieRepository(IDataSource<Movie, MovieRequest> dataSource)
		{
			this._dataSource = dataSource;
		}

		public async Task<Movie> Get(MovieRequest request)
		{
			return await _dataSource.Get(request);
		}
	}
}
