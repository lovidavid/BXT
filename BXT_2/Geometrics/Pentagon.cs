using BXT_2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Geometrics
{
    internal class Pentagon
    {
        public Position Centre { get; set; }

        public float Radius { get; set; }   

        public float Size { get; set; }

        public Pentagon(Position centre, float radius, float size)
        {
            Centre = centre;
            Radius = radius;
            Size = size;
        }

        public Pentagon(float a)
        {                        
            Radius = 1.720477401f * MathF.Pow(a, 2);
        }




    }
}
