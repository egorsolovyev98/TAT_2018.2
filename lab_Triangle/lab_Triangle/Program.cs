using System;

namespace lab_Triangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point2D a = new Point2D(0.0, 3.0);
            Point2D b = new Point2D(4.0, 0.0);
            Point2D c = new Point2D(0.0, 0.0);

            TriangleBuilder builder = new EquilateralTriangleBuilder(new RightTriangleBuilder(new SimpleTriangleBuilder(null)));
            Triangle triangle = builder.Create(a, b, c);
            double square = triangle.GetSquare();

            Console.WriteLine(square);
        }
    }
}
