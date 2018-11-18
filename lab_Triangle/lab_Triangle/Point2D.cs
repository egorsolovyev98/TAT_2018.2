using System;

namespace lab_Triangle
{
    /// <summary>
    /// Point on the plane.
    /// </summary>
    public struct Point2D
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>The x.</value>
        public double X { get; set; }


        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>The y.</value>
        public double Y { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="T:lab_Triangle.Point2D"/> struct.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// Gets the distance.
        /// </summary>
        /// <returns>The distance.</returns>
        /// <param name="point">Point.</param>
        public double GetDistance(Point2D point)
        {
            return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
        }
    }
}