namespace Inheritance;

public class Car : Vehicle
{
    public Car(int registrationNumber):base(registrationNumber)
    {
        Console.WriteLine("Car constructor " + registrationNumber);
    }
}