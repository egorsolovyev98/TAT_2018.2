using System;

namespace lab_Triangle
{
    /// <summary>
    /// Simple triangle builder.
    /// </summary>
    public class SimpleTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="next">Next triangle builder.</param>
        public SimpleTriangleBuilder(TriangleBuilder next) : base(next) { }


        /// <summary>
        /// Create the simple triangle.
        /// </summary>
        /// <returns>The triangle.</returns>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            return IsTriangleExists() ? new SimpleTriangle(a, b, c) : NextTriangleBuilder.Create(a, b, c);
        }


        /// <summary>
        /// Decides whether a triangle exists.
        /// </summary>
        /// <returns><c>true</c>, if triangle exists, <c>false</c> otherwise.</returns>
        public bool IsTriangleExists()
        {
            bool first = Math.Abs(AB - BC - AC) <= double.Epsilon;
            bool second = Math.Abs(BC - AC - AB) <= double.Epsilon;
            bool third = Math.Abs(AC - AB - BC) <= double.Epsilon;

            return first && second && third;
        }
    }
}