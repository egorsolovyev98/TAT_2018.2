using System;

namespace lab_Triangle
{
    public class SimpleTriangle : Triangle
    {
        public SimpleTriangle(Point2D a, Point2D b, Point2D c) : base (a, b, c) {}

        public override double GetSquare()
        {
            return Math.Sqrt((AB + BC + AC) * (-AB + BC + AC) * (AB - BC + AC) * (AB + BC - AC)) / 4;
        }
    }
}