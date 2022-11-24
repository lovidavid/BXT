using BXT_2.Geometrics;
using BXT_2.Utility;
using LanguageExt.TypeClasses;

class Program
{
    static void Main(string[] args)
    {
        Position position1 = new Position(0, 0);
        Position position2 = new Position(10, 10);

        Rectangle rectangle = new Rectangle(position1,position2);

        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Height);
        Console.WriteLine(rectangle.Centre);


        Console.ReadKey();

    }
        
    
}

