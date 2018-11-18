namespace lab_Triangle
{
    public class EquilateralTriangleBuilder : TriangleBuilder
    {
        public EquilateralTriangleBuilder(TriangleBuilder next) : base (next) {}
 
        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            AB = a.GetDistance(b);
            BC = b.GetDistance(c);
            AC = a.GetDistance(c);

            return IsEquilateralTriangle(a, b, c) ? new EquilateralTriangle(a, b, c) : Next.Create(a, b, c);
        }

        private bool IsEquilateralTriangle(Point2D a, Point2D b, Point2D c)
        {
            return AB.Equals(BC) && BC.Equals(AC);
        }
    }
}