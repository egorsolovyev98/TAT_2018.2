using System;
namespace lab_Triangle
{
    public class RightTriangleBuilder : TriangleBuilder
    {
        public RightTriangleBuilder(TriangleBuilder next) : base(next) { }

        public override Triangle Create(Point2D a, Point2D b, Point2D c)
        {
            if (IsRightTriangle(a, b, c))
            {
                return new RightTriangle(a, b, c);
            }
            else
            {
                return Next.Create(a, b, c);
            }
        }

        private bool IsRightTriangle(Point2D a, Point2D b, Point2D c)
        {
            double hypotenuse;
            double cathetus1;
            double cathetus2;

            double[] array = { AB, BC, AC };
            Array.Sort(array);

            hypotenuse = array[2];
            cathetus1 = array[1];
            cathetus2 = array[0];

            return Math.Pow(hypotenuse, 2).Equals(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
        }
    }
}
