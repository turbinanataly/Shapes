using System;

namespace Shapes
{
    /// <summary>
    /// Class to represent the triangle.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Triangle side.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Triangle side.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Triangle side.
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a">Triangle side.</param>
        /// <param name="b">Triangle side.</param>
        /// <param name="c">Triangle side.</param>
        public Triangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ArgumentException("The sides of a triangle cannot be negative or zero.");
            }

            if ((a >= b + c) || (b >= a + c) || (c >= a + b))
            {
                throw new ArgumentException("For a triangle, the sum of any two sides must be greater than the third.");
            }

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Area calculation.
        /// </summary>
        /// <returns>Area</returns>
        public double GetArea()
        {
            if ((A == 0) || (B == 0) || (C == 0))
            {
                return 0;
            }
            else
            {
                double p = GetPerimeter() / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        /// <summary>
        /// Perimeter сalculation.
        /// </summary>
        /// <returns>Perimeter</returns>
        public double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Check that the triangle is rectangular.
        /// </summary>
        /// <returns>True if rectangular. 
        /// False if not.</returns>
        public bool CheckSquareness()
        {
            if (((A > B) && (A > C) && (A * A == B * B + C * C)) 
                || ((B > A) && (B > C) && (B * B == A * A + C * C))
                || ((C > A) && (C > B) && (C * C == A * A + B * B)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("Triangle ({0}, {1}, {2})", A, B, C);
        }
    }
}
