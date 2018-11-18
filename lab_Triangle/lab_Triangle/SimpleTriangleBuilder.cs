using System;
namespace lab_Triangle
{
    public class SimpleTriangleBuilder : TriangleBuilder
    {
        public SimpleTriangleBuilder(TriangleBuilder next) : base(next) { }

        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            if (IsTriangleExists())
            {
                return new SimpleTriangle(a, b, c);
            }
            else
            {
                return Next.Create(a, b, c);
            }
        }

        public bool IsTriangleExists()
        {
            bool first = Math.Abs(AB - BC - AC) <= double.Epsilon;
            bool second = Math.Abs(BC - AC - AB) <= double.Epsilon;
            bool third = Math.Abs(AC - AB - BC) <= double.Epsilon;

            return first && second && third;
        }
    }
}
