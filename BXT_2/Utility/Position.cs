using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXT_2.Utility
{
    public record class Position(float X, float Y)
    {
        public static Position operator +(Position a, Position b) => new(a.X + b.X, a.Y + b.Y);
        public static Position operator -(Position a) => new(-a.X, -a.Y);
        public static Position operator -(Position a, Position b) => a + -b;
    }


    public record class Position3D(float X, float Y, float Z)
    {
        public static Position3D operator + (Position3D a, Position3D b) => new(a.X + b.X , a.Y + b.Y , a.Z + b.Z);

        public static Position3D operator -(Position3D a) => new(-a.X, -a.Y, -a.Z);

        public static Position3D operator -(Position3D a, Position3D b) => a + -b;
    }
    


}

