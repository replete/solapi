using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sol.Models;
using Sol.Services;

namespace Sol.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService) => _userService = userService;


		[HttpGet]
		public ActionResult<List<User>> Get() => _userService.Get();


		[HttpGet("{id:length(24)}")]
		public ActionResult<User> Get(string id)
		{
			var user = _userService.Get(id);
			if (user != null) return user;
			return NotFound();
		}
	}
}