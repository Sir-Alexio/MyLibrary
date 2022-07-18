using System;

namespace MyLibrary
{
    public class Triangle : ISquare
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            //Does triangle exist
            if (a+b<c || a+c<b || c+b<a)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            A = a;
            B = b;
            C = c;
              
        }

        public double MakeSquare()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //heron's formula of making square
        }

        public bool isTriangleRight()
        {
            // The Pythagorean proposition
            if (A > B && A > C)
            {
                return A * A == B * B + C * C;
            }
            else if (B > A && B > C)
            {
                return B * B == A * A + C * C;
            }
            else
            {
                return C * C == A * A + B * B;
            }
        }
    }
}
