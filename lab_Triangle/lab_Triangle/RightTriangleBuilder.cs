using System;

namespace lab_Triangle
{
    /// <summary>
    /// Right triangle builder.
    /// </summary>
    public class RightTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="next">Next triangle builder.</param>
        public RightTriangleBuilder(TriangleBuilder next) : base(next) { }


        /// <summary>
        /// Create the right triangle.
        /// </summary>
        /// <returns>The triangle.</returns>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            return IsRightTriangle() ? new RightTriangle(a, b, c) : NextTriangleBuilder.Create(a, b, c);
        }


        /// <summary>
        /// Decides whether a triangle is right.
        /// </summary>
        /// <returns><c>true</c>, if triangle is right, <c>false</c> otherwise.</returns>
        private bool IsRightTriangle()
        {
            double hypotenuse;
            double cathetus1;
            double cathetus2;

            double[] array = { AB, BC, AC };
            Array.Sort(array);

            hypotenuse = array[2];
            cathetus1 = array[1];
            cathetus2 = array[0];

            return Math.Pow(hypotenuse, 2).Equals(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
        }
    }
}