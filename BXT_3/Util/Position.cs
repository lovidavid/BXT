using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_3.Util
{
     public record class Position (float X, float Y)
    {
        public static Position operator +(Position a, Position b) => new(a.X + b.X, a.Y + b.Y);
        public static Position operator -(Position a) => new(-a.Y, -a.Y);
        public static Position operator -(Position a, Position b) => a + -b;
    }
}
