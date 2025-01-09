namespace Polymorphism;

public abstract class Shape
{
    public int Width { get; set; }

    public int Height { get; set; }

    public abstract void Draw();

    public void Copy()
    {
        Console.WriteLine("Shape was copied!");
    }

    public void Select()
    {
        Console.WriteLine("Shape was selected!");
    }
}