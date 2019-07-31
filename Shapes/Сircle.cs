using System;

namespace Shapes
{
    /// <summary>
    /// Class to represent the circle.
    /// </summary>
    public class Circle : IShape
    {
        public const double Pi = 3.14159;

        /// <summary>
        /// Circle radius.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius of the circle can not be negative or zero.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Area calculation.
        /// </summary>
        /// <returns>Area</returns>
        public double GetArea()
        {
            return Pi * Radius * Radius;
        }

        /// <summary>
        /// Perimeter сalculation.
        /// </summary>
        /// <returns>Perimeter</returns>
        public double GetPerimeter()
        {
            return 2 * Radius * Pi;
        }

        public override string ToString()
        {
            return String.Format("Circle (R = {0})", Radius);
        }
    }
}
