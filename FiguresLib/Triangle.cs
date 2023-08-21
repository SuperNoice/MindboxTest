namespace FiguresLib
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRight => CheckRight();

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            // Полупериметр
            var p = (SideA + SideB + SideC) / 2.0d;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private bool CheckRight()
        {
            var Sides = new double[] { SideA, SideB, SideC };
            Array.Sort(Sides);

            return (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2)) == Math.Pow(Sides[2], 2);
        }
    }
}
