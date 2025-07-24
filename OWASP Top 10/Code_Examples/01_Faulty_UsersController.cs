// Description: This code defines a UsersController in an ASP.NET Core application that has a vulnerability due to a missing access check on an endpoint.
// Vulnerable Code (Broken Access Control)

using Microsoft.AspNetCore.Mvc;
using MyApplication.Services.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
	private readonly IUserService _userService;

	public UsersController(IUserService userService)
	{
		_userService = userService;
	}

	// ❌ This endpoint is vulnerable: no access check
	[HttpGet("all")]
	public IActionResult GetAllUsers()
	{
		var users = _userService.GetAllUsers();
		return Ok(users);
	}
}
