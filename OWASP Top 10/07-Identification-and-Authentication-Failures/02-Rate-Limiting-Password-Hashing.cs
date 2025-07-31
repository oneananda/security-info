[HttpPost("login")]
public IActionResult Login(LoginRequest req)
{
    var user = _db.Users.FirstOrDefault(u => u.Username == req.Username);
    if (user == null || !BCrypt.Net.BCrypt.Verify(req.Password, user.PasswordHash))
    {
        _loginAttemptService.RegisterFailedAttempt(req.Username);
        return Unauthorized("Invalid credentials");
    }

    if (_loginAttemptService.IsLockedOut(req.Username))
        return Forbid("Account temporarily locked");

    return Ok("Login successful");
}
