using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyСircle : ISquare
    {
        public double Radius { get; }

        public MyСircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }

            Radius = radius;
        }

        public double MakeSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
