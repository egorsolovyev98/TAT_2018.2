using System;

namespace lab_Triangle
{
    /// <summary>
    /// Simple triangle.
    /// </summary>
    public class SimpleTriangle : Triangle
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public SimpleTriangle(Point2D a, Point2D b, Point2D c) : base (a, b, c) {}


        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <returns>The square.</returns>
        public override double GetSquare()
        {
            return Math.Sqrt((AB + BC + AC) * (-AB + BC + AC) * (AB - BC + AC) * (AB + BC - AC)) / 4;
        }
    }
}