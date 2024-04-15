using Microsoft.AspNetCore.Mvc;
using Pustok.Models;

namespace Pustok.Controllers
{
	public class AccountController :Controller
	{
		public IActionResult Login()
		{
			return View();	
		}

		public IActionResult Register()
		{
			return View();
		}
	}
}
