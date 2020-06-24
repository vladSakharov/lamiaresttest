using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Models;

namespace LamiaRestTest.Repositories
{
	public class MovieRequest : IDataRequest<Movie>
	{
		public enum PlotType
		{
			SHORT = 0,
			FULL = 1
		}

		public MovieRequest(string title, int year, string version)
		{
			this._title = title;
			this._year = year;
			Enum.TryParse(version, out _version);
		}

		private string _title;
		private int _year;
		private PlotType _version;

		public string Title => _title;

		public int Year => _year;

		public string Version
		{
			get
			{
				return _version.ToString().ToLower();
			}
		}
	}
}
