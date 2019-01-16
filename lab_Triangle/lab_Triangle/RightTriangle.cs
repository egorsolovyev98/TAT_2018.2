using System;

namespace lab_Triangle
{
    /// <summary>
    /// Right triangle.
    /// </summary>
    public class RightTriangle : Triangle
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public RightTriangle(Point2D a, Point2D b, Point2D c) : base(a, b, c) { }


        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <returns>The square.</returns>
        public override double GetSquare()
        {
            double[] array = { AB, BC, AC };
            Array.Sort(array);

            double cathetus1 = array[1];
            double cathetus2 = array[0];

            return cathetus1 * cathetus2 / 2;
        }
    }
}