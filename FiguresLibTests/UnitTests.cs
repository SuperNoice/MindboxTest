using FiguresLib;

namespace FiguresLibTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 5, 4);
            Assert.IsTrue(triangle.GetArea() == 6d);
        }

        [Test]
        public void TriangleRightTest()
        {
            var triangle = new Triangle(5, 4, 3);

            Assert.IsTrue(triangle.IsRight);

            triangle.SideA = 4;

            Assert.IsFalse(triangle.IsRight);
        }

        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(3);
            Assert.IsTrue(circle.GetArea() == 28.274333882308138d);
        }

        [Test]
        public void MixedFiguresAreaTest()
        {
            var figures = new IFigure[]
            {
                new Triangle(4, 5, 3),
                new Circle(3),
            };

            Assert.IsTrue(figures[0].GetArea() == 6d);
            Assert.IsTrue(figures[1].GetArea() == 28.274333882308138d);
        }
    }
}