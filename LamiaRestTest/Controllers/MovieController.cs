using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Models;
using LamiaRestTest.Repositories;
using LamiaRestTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LamiaRestTest.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{

		private readonly IDbService<Movie, MovieRequest> _movieService;

		public MovieController(IDbService<Movie, MovieRequest> movieService)
		{
			this._movieService = movieService;
		}

		// GET api/<MovieController>/title/year/version
		[HttpGet("{title}/{year}/{version}")]
		public async Task<Movie> Get(string title, int year, string version)
		{
			var movie = await _movieService.Get(new MovieRequest(title, year, version));
			return movie;
		}

	}
}
