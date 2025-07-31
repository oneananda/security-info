[HttpPost("login")]
public IActionResult Login(LoginRequest req)
{
    var user = _db.Users.FirstOrDefault(u => u.Username == req.Username);
    if (user != null && user.Password == req.Password)
    {
        // ❌ Plain-text comparison and no lockout
        return Ok("Login successful");
    }

    return Unauthorized("Invalid credentials");
}
