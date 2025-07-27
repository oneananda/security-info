// This ensures the user input is treated as a literal value, not executable SQL.

public bool Login(string username, string password)
{
    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

    SqlCommand cmd = new SqlCommand(query, _connection);
    cmd.Parameters.AddWithValue("@username", username);
    cmd.Parameters.AddWithValue("@password", password);

    _connection.Open();
    int count = (int)cmd.ExecuteScalar();
    _connection.Close();

    return count > 0;
}
