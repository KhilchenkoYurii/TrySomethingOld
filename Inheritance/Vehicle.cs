namespace Inheritance;

public class Vehicle
{
    private int _regirtrationnumber;

    public Vehicle(int registrationNumber)
    {
        Console.WriteLine("Base constructor " + registrationNumber);
    }
}