// Description: This code defines a UsersController in an ASP.NET Core application that has a vulnerability due to a missing access check on an endpoint.
// This allows any authenticated user to access all users, which could lead to unauthorized data exposure.
// Fixed Code (Proper Access Control)
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    // ✅ Restrict to Admin role
    [Authorize(Roles = "Admin")]
    [HttpGet("all")]
    public IActionResult GetAllUsers()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }

    // ✅ Regular users can only get their own info
    [Authorize]
    [HttpGet("me")]
    public IActionResult GetMyInfo()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var user = _userService.GetUserById(userId);
        return Ok(user);
    }
}
