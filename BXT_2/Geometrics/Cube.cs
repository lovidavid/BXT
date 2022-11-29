using BXT_2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Geometrics
{
    internal class Cube
    {
        public Position Centre { get; set; }

        public float Size { get; set; }


        public Cube(Position centre, float size)
        {
            this.Centre = centre;
            this.Size = size;
        }

     


        public void Move(Position delta)
        {
            Centre += delta;
        }

        public float CalculateArea()
        {
            return MathF.Pow(Size, 3);
        }

        public float CalculateSurface()
        {
            return 6 * MathF.Pow(Size,2);
        }


    }
}
