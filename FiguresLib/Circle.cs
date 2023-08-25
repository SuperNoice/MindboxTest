namespace FiguresLib
{
    public struct Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Рариус круга не может быть меньше 0");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}