namespace FiguresLib
{
    public struct Triangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public bool IsRight => CheckRight();

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше либо равна 0");
            }
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
