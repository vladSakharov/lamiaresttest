using System.Threading.Tasks;
using LamiaRestTest.ExternalData;
using LamiaRestTest.Models;
using LamiaRestTest.Repositories;

namespace LamiaRestTest.Services
{
	public class MovieService : IDbService<Movie, MovieRequest>
	{

		private readonly IRepository<Movie, IDataSource<Movie, MovieRequest>, MovieRequest> _movieRepository;

		public MovieService(IRepository<Movie, IDataSource<Movie, MovieRequest>, MovieRequest> movieRepository)
		{
			this._movieRepository = movieRepository;
		}

		public async Task<Movie> Get(MovieRequest request)
		{
			return await _movieRepository.Get(request);
		}

		
	}
}
