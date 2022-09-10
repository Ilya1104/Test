using FigureLibrary;
using NUnit.Framework;
using System;

namespace TestLibrary
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void NegativeCircleRadius()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-5d));
        }
        [Test]
        public void NormalCircleRadius()
        {
            var circle = new Circle(5);
            var circleSquare = circle.FigureSquare();
            Assert.AreEqual(78.539816339744831d, circleSquare);
        }


        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void ErrorInitTriangle(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }
        [TestCase(3, 4, 3, ExpectedResult = false)]
        [TestCase(6, 8, 10, ExpectedResult = true)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.000000001, ExpectedResult = false)]
        public bool IsRectangular(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isRight = triangle.IsRectangular;
            return isRight;
        }
    }
}