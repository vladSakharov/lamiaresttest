using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamiaRestTest.Models
{
	public class AuthenticateResponse
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Token { get; set; }


		public AuthenticateResponse(User user, string token)
		{
			Username = user.Username;
			Token = token;
		}
	}
}
