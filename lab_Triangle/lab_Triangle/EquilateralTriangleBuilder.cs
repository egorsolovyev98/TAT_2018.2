namespace lab_Triangle
{
    /// <summary>
    /// Equilateral triangle builder.
    /// </summary>
    public class EquilateralTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="next">Next triangle builder.</param>
        public EquilateralTriangleBuilder(TriangleBuilder next) : base (next) {}


        /// <summary>
        /// Create the equilateral triangle.
        /// </summary>
        /// <returns>The triangle.</returns>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            AB = a.GetDistance(b);
            BC = b.GetDistance(c);
            AC = a.GetDistance(c);

            return IsEquilateralTriangle() ? new EquilateralTriangle(a, b, c) : NextTriangleBuilder.Create(a, b, c);
        }


        /// <summary>
        /// Decides whether a triangle is equilateral.
        /// </summary>
        /// <returns><c>true</c>, if triangle is equilateral, <c>false</c> otherwise.</returns>
        private bool IsEquilateralTriangle()
        {
            return AB.Equals(BC) && BC.Equals(AC);
        }
    }
}