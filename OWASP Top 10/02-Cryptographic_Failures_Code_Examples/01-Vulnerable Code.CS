using System.Collections.Generic;

public class UserService
{
    private readonly Dictionary<string, string> _users = new();

    public void Register(string username, string password)
    {
        // ❌ Do NOT store passwords in plain text!
        _users[username] = password;
    }

    public bool Login(string username, string password)
    {
        return _users.TryGetValue(username, out var storedPassword) && storedPassword == password;
    }
}
