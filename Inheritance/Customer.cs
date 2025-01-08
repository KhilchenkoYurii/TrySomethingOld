namespace Inheritance;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
        if(CalculateRating() == 0)
            Console.WriteLine("Promote to level 1");
        else
        {
            Console.WriteLine("Promote to lvl 2");
        }
    }

    private int CalculateRating()
    {
        return 0;
    }
}