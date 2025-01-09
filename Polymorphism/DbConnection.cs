namespace Polymorphism;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }

    public TimeSpan Timeout { get; set; }

    public DbConnection(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString can`t be null or empty");
        }

        ConnectionString = connectionString;

        Timeout = TimeSpan.FromSeconds(60);
    }

    public abstract void OpenConnection();

    public abstract void CloseConnection();
}