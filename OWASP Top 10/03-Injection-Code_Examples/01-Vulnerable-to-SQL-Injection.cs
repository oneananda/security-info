public class AuthService
{
    private readonly SqlConnection _connection;

    public AuthService(string connectionString)
    {
        _connection = new SqlConnection(connectionString);
    }

    public bool Login(string username, string password)
    {
        // ❌ Unsafe query with string concatenation
        string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}'";

        SqlCommand cmd = new SqlCommand(query, _connection);
        _connection.Open();
        int count = (int)cmd.ExecuteScalar();
        _connection.Close();

        return count > 0;
    }
}
