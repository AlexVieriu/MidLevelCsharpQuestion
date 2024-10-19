public class Program
{
    //(this code is commented as the type of this project is class library,
    //not the Console Application

    public static void Main(string[] args)
    {
        var personalDataFormatter = new PersonalDataFormatter(
            new DatabasePeopleDataReader());

        Console.WriteLine(personalDataFormatter.Format());

        var enthusiasticGreeter = new EnthusiasticGreeter(
            message => Console.WriteLine(message));

        enthusiasticGreeter.PrintHelloNTimes(5);

        Console.ReadKey();
    }
}
