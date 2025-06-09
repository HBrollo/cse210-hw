using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 3, 9);
        shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 9);
        shapes.Add(c1);

        foreach (Shape sp in shapes)
        {
            Console.WriteLine($"This shape's color is {sp.GetColor()}");
            Console.WriteLine($"This shape's area is {sp.GetArea()}");
        }
    }
}