namespace lab_Triangle
{
    /// <summary>
    /// Triangle builder.
    /// </summary>
    public abstract class TriangleBuilder
    {
        /// <summary>
        /// Gets or sets the side of the triangle.
        /// </summary>
        /// <value>The ab.</value>
        public double AB { get; set; }


        /// <summary>
        /// Gets or sets the side of the triangle.
        /// </summary>
        /// <value>The bc.</value>
        public double BC { get; set; }


        /// <summary>
        /// Gets or sets the side of the triangle.
        /// </summary>
        /// <value>The ac.</value>
        public double AC { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="next">Next triangle builder.</param>
        protected TriangleBuilder(TriangleBuilder next)
        {
            NextTriangleBuilder = next;
        }


        /// <summary>
        /// Gets or sets the next triangle builder.
        /// </summary>
        /// <value>The next triangle builder.</value>
        public TriangleBuilder NextTriangleBuilder { get; set; }


        /// <summary>
        /// Create the triangle.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        public abstract Triangle Create(Point2D a, Point2D b, Point2D c);
    }
}