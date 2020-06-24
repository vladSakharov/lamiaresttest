using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamiaRestTest.Controllers;
using LamiaRestTest.Models;

namespace LamiaRestTest.Services
{
	public interface IUserService
	{
		AuthenticateResponse Authenticate(AuthenticateRequest model);
		IEnumerable<User> GetAll();
	}
}
