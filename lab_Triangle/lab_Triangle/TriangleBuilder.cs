using System;

namespace lab_Triangle
{
    public abstract class TriangleBuilder
    {
        public double AB { get; set; }
        public double BC { get; set; }
        public double AC { get; set; }

        protected TriangleBuilder(TriangleBuilder next)
        {
            Next = next;
        }
        public TriangleBuilder Next { get; set; }
        public abstract Triangle Create(Point2D a, Point2D b, Point2D c);
    }
}
