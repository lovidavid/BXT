using BXT_2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Geometrics
{
    public class Circle
    {
        public Position Centre { get; set; }

        public Position CirclePoint { get; set; }

        public Position Point { get; set; }

        public float Radius { get; set; }

        public float Diameter { get; init; } 


        public Circle(Position centre, Position circlePoint, float radius, float diameter)
        {
            this.Centre = centre;
            this.CirclePoint = circlePoint;
            this.Radius = radius;
            this.Diameter = radius * 2;
        }

        public Circle(float radius)
        {
            this.Diameter= radius * 2;
        }

        public Circle(Position centre, Position circlePoint)
        {
            if (centre == circlePoint)
            {
                throw new ArgumentException("Not a line");
            }

            this.Radius = MathF.Sqrt(MathF.Pow(centre.X - circlePoint.X, 2) + MathF.Pow(centre.Y - circlePoint.Y, 2));

        }

        public Circle(Position centre, Position point, float radius)
        {
            if(MathF.Pow((point.X-centre.X),2)+MathF.Pow((point.Y-centre.Y),2) < (MathF.Pow(radius,2)))
            {
                Console.WriteLine("Körön belül van a pont");
            }
            else if (MathF.Pow((point.X - centre.X), 2) + MathF.Pow((point.Y - centre.Y), 2) == (MathF.Pow(radius, 2)))
            {
                Console.WriteLine("Körön van a pont");
            }
            else
            {
                Console.WriteLine("Körön kivül van a pont");
            }
            

        }

        public void Move(Position delta)
        {
            Centre += delta;
            CirclePoint += delta;
            
        }

        public float CalculatedArea()
        {
            return Radius * Radius * float.Pi;
        }

        public float CalculatedPerimeter()
        {
            return 2* Radius* float.Pi;
        }

        public float EnclosingSquareArea()
        {
            return MathF.Pow(Diameter, 2);
        }

    }
}
