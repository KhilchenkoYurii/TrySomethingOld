namespace Polymorphism;

public class DbCommand
{
    private DbConnection _connection;

    public string Instruction { get; set; }

    public DbCommand(DbConnection connection)
    {
        if (connection == null)
        {
            throw new Exception("DbConnection is null");
        }

        _connection = connection;
    }

    public void Execute(string instructions)
    {
        if (string.IsNullOrEmpty(instructions))
        {
            throw new Exception("Instructions can`t be empty or null");
        }

        _connection.OpenConnection();

        Console.WriteLine($"Run instructions from user: {instructions}");

        _connection.CloseConnection();
    }


}