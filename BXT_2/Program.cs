using BXT_2.Geometrics;
using BXT_2.Utility;


class Program
{
    static void Main(string[] args)
    {
        Position position1 = new Position(0, 0);
        Position position2 = new Position(10, 10);
        Position position3 = new Position(1, 10);

        Rectangle rectangle = new Rectangle(position1,position2);
        

        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Height);
        Console.WriteLine(rectangle.Centre);
        Console.WriteLine();

        //Rectangle rectangle2 = new Rectangle(position1, Width, Height);

        Rectangle rectangle3 = new Rectangle(position1,position2,position3);
        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Height);
        Console.WriteLine(rectangle.Centre);
        Console.WriteLine();


        Console.WriteLine("A négyzet területe: {0}", rectangle.CalculatedArea());
        Console.WriteLine("A négyzet térfogata: {0}", rectangle.CalculatedPerimeter());








        Console.ReadKey();

    }
        
    
}

