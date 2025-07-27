// This code demonstrates a simple authentication service using Entity Framework.
using System.Linq;
using Microsoft.EntityFrameworkCore;


public class AuthServiceEF
{
    private readonly AppDbContext _dbContext;

    public AuthServiceEF(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool Login(string username, string password)
    {
        return _dbContext.Users.Any(u => u.Username == username && u.Password == password);
    }
}
