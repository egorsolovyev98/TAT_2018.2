using System;
namespace lab_Triangle
{
    public class RightTriangle : Triangle
    {
        private double Hypotenuse { get; set; }
        private double Cathetus1 { get; set; }
        private double Cathetus2 { get; set; }

        public RightTriangle(Point2D a, Point2D b, Point2D c) : base(a, b, c) 
        {
            double[] array = { AB, BC, AC };
            Array.Sort(array);

            Hypotenuse = array[2];
            Cathetus1 = array[1];
            Cathetus2 = array[0];

            if (!IsRightTriangle())
            {
                throw new Exception("Not a right triangle.");
            }
        }

        public override double GetSquare()
        {
            return Cathetus1 * Cathetus2 / 2;
        }

        private bool IsRightTriangle()
        {
            return Math.Pow(Hypotenuse, 2).Equals(Math.Pow(Cathetus1, 2) + Math.Pow(Cathetus2, 2));
        }
    }
}
