using BCrypt.Net;
using System.Collections.Generic;

public class UserService
{
    private readonly Dictionary<string, string> _users = new();

    public void Register(string username, string password)
    {
        // ✅ Store hashed password
        var hashed = BCrypt.Net.BCrypt.HashPassword(password);
        _users[username] = hashed;
    }

    public bool Login(string username, string password)
    {
        if (!_users.TryGetValue(username, out var hashed)) return false;

        // ✅ Compare using hash verification
        return BCrypt.Net.BCrypt.Verify(password, hashed);
    }
}
