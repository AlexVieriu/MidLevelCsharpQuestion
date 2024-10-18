// Best example: https://www.youtube.com/watch?v=EPv9-cHEmQw
// Code: https://github.com/AlexVieriu/DotNetTheory/blob/master/DependencyInjection/TheSimpleEngineer_DI/Program.cs
using static System.Console;

var user = new User();
var userIoc = new UserIoc(new OracleDatabase());
user.Add("This is a bad way");
userIoc.Add("This is a good way");

// Business Layer Logic
public class User                               // Procedural Programming Flow of Control
{
    MySqlDatabase database;

    public User()
       => database = new MySqlDatabase();

    public void Add(string data)
       => database.Persist(data);
}

public class UserIoc                            // Structured Ioc(Inversion of Control)
{
    private readonly IDataBase _database;
    public UserIoc(IDataBase database)
        => _database = database;
    public void Add(string data)
        => _database.Persist(data);
}

public interface IDataBase
{
    void Persist(string data);
}

// Database Access layer
public class MySqlDatabase : IDataBase
{
    public void Persist(string data)
       => WriteLine("MySqlDatabase" + data);
}


public class OracleDatabase : IDataBase
{
    public void Persist(string data)
        => WriteLine("OracleDatabase:" + data);
}

public class SqlServerDatabase : IDataBase
{
    public void Persist(string data)
        => WriteLine("SqlServerDatabase: " + data);
}