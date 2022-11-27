using BXT_2.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Geometrics
{
    public class Line
    {
        public Position Start { get; set; }
        public Position End { get; set; }

        public float Size { get; init; } 

        public Line(Position start, Position end, float size)
        {
            this.Start = start;
            this.End = end;
            this.Size = size;
        }

        public Line(Position start, Position end)
        {
            if(start == end)
            {
                throw new ArgumentException("Not a line");
            }

            this.Size = MathF.Sqrt(MathF.Pow(end.X - start.X, 2)+MathF.Pow(end.Y-start.Y,2));
            
        }

        public void Move(Position delta)
        {
            Start += delta;
            End += delta;
        }



    }
}
