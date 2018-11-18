using System;

namespace lab_Triangle
{
    public class EquilateralTriangle : Triangle 
    {
        public EquilateralTriangle (Point2D a, Point2D b, Point2D c) : base (a, b, c) 
        {
            if (!IsEquilateralTriangle())
            {
                throw new Exception("Not a equilateral triangle.");
            }
        }

        public override double GetSquare()
        {
            return Math.Sqrt(3.0) / 4 * Math.Pow(AB, 2);
        }

        private bool IsEquilateralTriangle()
        {
            return AB.Equals(BC) && BC.Equals(AC);
        }
    }
}
