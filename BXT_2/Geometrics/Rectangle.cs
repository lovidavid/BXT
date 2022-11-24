using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BXT_2.Utility;

namespace BXT_2.Geometrics
{
    internal class Rectangle
    {
      
        public Position Centre { get; set; }
        public float Width { get; init; }
        public float Height { get; init; }

        //public float Rotation { get; init; }

        public Rectangle()
        {
            Console.WriteLine("Ez egy négyzet");
        }

        public Rectangle(Position centre, float Width, float Height)
        {
            this.Centre= centre;
            this.Width = Width;
            this.Height = Height;
        }
        public Rectangle(Position bottomLeft, Position topRight)
        {
            this.Width = topRight.X - bottomLeft.X;
            this.Height = topRight.Y - bottomLeft.Y;
            this.Centre = new Position(bottomLeft.X + Width/2, bottomLeft.Y + Height/2);
        }

        public Rectangle(Position first, Position second, Position third)
        {
            if((third.X == second.X && third.Y == first.Y) || (third.X == first.X && third.Y == second.Y))
            {
                throw new ArgumentException("Not a rectangle");
            }

            this.Width = second.X - first.X;
            this.Height= second.Y - first.Y;
            this.Centre= new Position(second.X - (second.X-first.X)/2, second.Y-(second.Y - first.Y) / 2);
        }


        public Position TopRightCorner { get => Centre - new Position(Width / 2, Height / 2); }
        public Position BottomLeftCorner { get => Centre + new Position(Width / 2, Height / 2); }

        public Position TopLeftCorner { get => Centre - new Position(-Width / 2, Height / 2); }
        public Position BottomRightCorner { get => Centre - new Position(Width / 2, -Height / 2); }

        public void Move(Position delta)
        {
            Centre += delta;
        }

        public float CalculatedArea()
        {
            return Width* Height;
        }

        public float CalculatedPerimeter()
        {
            return 2 * (Width + Height);
        }

    }
}
