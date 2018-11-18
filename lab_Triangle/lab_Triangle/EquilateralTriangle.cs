using System;

namespace lab_Triangle
{
    /// <summary>
    /// Equilateral triangle.
    /// </summary>
    public class EquilateralTriangle : Triangle 
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle..</param>
        public EquilateralTriangle (Point2D a, Point2D b, Point2D c) : base (a, b, c) { }


        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <returns>The square.</returns>
        public override double GetSquare()
        {
            return Math.Sqrt(3.0) / 4 * Math.Pow(AB, 2);
        }
    }
}