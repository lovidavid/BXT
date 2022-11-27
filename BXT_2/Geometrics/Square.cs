using BXT_2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Geometrics
{
    internal class Square
    {
        public Position Centre { get; set; }

        public float Size { get; set; }


        public Square (Position centre, float size)
        {
            this.Centre = centre;
            this.Size = size;
        }

        public Square (Position bottomLeft , Position topRight)
        {
            if(topRight.X - bottomLeft.X != topRight.Y-bottomLeft.Y)
            {
                throw new ArgumentException("Not a square");
            }

            this.Size= topRight.Y - bottomLeft.Y;
            this.Centre = new Position (bottomLeft.X + Size /2, bottomLeft.Y + Size /2);
        }

        public Position TopRightCorner { get => Centre + new Position(Size / 2, Size / 2); }
        public Position BottomLeftCorner { get => Centre - new Position(Size  / 2, Size / 2); }

        public Position TopLeftCorner { get => Centre + new Position(Size / 2, -Size / 2); }
        public Position BottomRightCorner { get => Centre + new Position(-Size / 2, Size / 2); }


        public void Move(Position delta)
        {
            Centre += delta;
        }

        public float CalculateArea()
        {
            return MathF.Pow(Size, 2);
        }

        public float CalculatePerimeter()
        {
            return 4 * Size;
        }
    }
}
