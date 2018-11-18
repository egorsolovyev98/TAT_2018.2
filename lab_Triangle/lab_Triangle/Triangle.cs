using System;

namespace lab_Triangle
{
    public abstract class Triangle
    {
        public Point2D A { get; set; }
        public Point2D B { get; set; }
        public Point2D C { get; set; }

        public double AB { get; set; }
        public double BC { get; set; }
        public double AC { get; set; }

        protected Triangle(Point2D a, Point2D b, Point2D c)
        {
            if (!IsTriangleExists())
            {
                throw new Exception("Impossible to build a triangle at given points.");
            }

            A = a;
            B = b;
            C = c;

            AB = A.GetDistance(B);
            BC = B.GetDistance(C);
            AC = A.GetDistance(C);
        }

        protected bool IsTriangleExists()
        {
            bool first = Math.Abs(AB - BC - AC) <= double.Epsilon;
            bool second = Math.Abs(BC - AC - AB) <= double.Epsilon;
            bool third = Math.Abs(AC - AB - BC) <= double.Epsilon;
            
            return first && second && third;
        }


        public abstract double GetSquare();
    }
}
