namespace lab_Triangle
{
    /// <summary>
    /// Triangle.
    /// </summary>
    public abstract class Triangle
    {
        /// <summary>
        /// Gets or sets vertex of the triangle.
        /// </summary>
        /// <value>A.</value>
        public Point2D A { get; set; }


        /// <summary>
        /// Gets or sets vertex of the triangle.
        /// </summary>
        /// <value>The b.</value>
        public Point2D B { get; set; }


        /// <summary>
        /// Gets or sets vertex of the triangle.
        /// </summary>
        /// <value>The c.</value>
        public Point2D C { get; set; }


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
        /// Initializes a new instance of the <see cref="T:lab_Triangle.Triangle"/> class.
        /// </summary>
        /// <param name="a">Vertex of the triangle.</param>
        /// <param name="b">Vertex of the triangle.</param>
        /// <param name="c">Vertex of the triangle.</param>
        protected Triangle(Point2D a, Point2D b, Point2D c)
        {
            A = a;
            B = b;
            C = c;

            AB = A.GetDistance(B);
            BC = B.GetDistance(C);
            AC = A.GetDistance(C);
        }


        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <returns>The square.</returns>
        public abstract double GetSquare();
    }
}