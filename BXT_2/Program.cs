using BXT_2.Geometrics;
using BXT_2.Utility;


class Program
{
    static void Main(string[] args)
    {
        Position position1 = new Position(0, 0);
        Position position2 = new Position(10, 10);
        Position position3 = new Position(0, 10);
        float Width = 10;
        float Height = 10;

        

        Rectangle rectangle = new Rectangle(position1,position2);
        

        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Height);
        Console.WriteLine(rectangle.Centre);
        Console.WriteLine();

        Rectangle rectangle1 = new Rectangle(position1, Width, Height);

        Console.WriteLine(rectangle1.Width);
        Console.WriteLine(rectangle1.Height);
        Console.WriteLine(rectangle1.Centre);
        Console.WriteLine();


        
        
            Rectangle rectangle2 = new Rectangle(position1, position2, position3);
            Console.WriteLine(rectangle2.Width);
            Console.WriteLine(rectangle2.Height);
            Console.WriteLine(rectangle2.Centre);
            Console.WriteLine();
        
       

        Console.WriteLine("A téglalap területe: {0}", rectangle.CalculatedArea());
        Console.WriteLine("A téglalap térfogata: {0}", rectangle.CalculatedPerimeter());
        Console.WriteLine();

        Console.WriteLine(rectangle.TopLeftCorner);
        Console.WriteLine(rectangle.BottomLeftCorner);
        Console.WriteLine(rectangle.BottomRightCorner);
        Console.WriteLine(rectangle.TopRightCorner);
        Console.WriteLine();

        Line line = new Line(position1,position3);
        Console.WriteLine(line.Size);
        Console.WriteLine();

        List<float> StartPointsX = new List<float>();
        List<float> StartPointsY = new List<float>();
        List<float> EndPointsX = new List<float>();
        List<float> EndPointsY = new List<float>();

        for (int i = 0; i < 10; i++)
        {
            StartPointsX.Add(i);
            StartPointsY.Add(i);
            EndPointsX.Add(i+1);
            EndPointsY.Add(i+1);

        }

        //create loops to fill the list and create the lines by 2 points
        Position StartPoint = new Position(StartPointsX[0], StartPointsY[0]);
        Position EndPoint = new Position(EndPointsX[0], EndPointsY[0]);

        Line line2 = new Line(StartPoint, EndPoint);

        Line newLine = new(new(0, 0), new(2, 3));




        Console.ReadKey();

    }
        
    
}

