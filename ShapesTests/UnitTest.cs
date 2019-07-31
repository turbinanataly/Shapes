using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class UnitTest
    {
        //Сreating a triangle with a negative side
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleWithNegativeSide()
        {
            Triangle triangle = new Triangle(5, 4, -2);
        }

        //Creating a triangle with the wrong sides
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleWithWrongSides()
        {
            Triangle triangle = new Triangle(5, 4, 10);
        }

        //Сalculating the perimeter of a triangle
        [TestMethod]
        public void TestTriangleСalculatingPerimeter()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(12, triangle.GetPerimeter());
        }

        //Calculating the area of a triangle
        [TestMethod]
        public void TestTriangleСalculatingArea()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(6, triangle.GetArea());
        }

        //Check the triangle for squareness (true)
        [TestMethod]
        public void TestTriangleCheckSquarenessTrue()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(true, triangle.CheckSquareness());
        }

        //Check the triangle for squareness (false)
        [TestMethod]
        public void TestTriangleCheckSquarenessFalse()
        {
            Triangle triangle = new Triangle(5, 3, 3);
            Assert.AreEqual(false, triangle.CheckSquareness());
        }

        //Сreating a circle with a negative radius
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestСircleWithNegativeRadius()
        {
            Circle сircle = new Circle(-1);
        }

        //Сalculating the perimeter of a circle
        [TestMethod]
        public void TestCircleСalculatingPerimeter()
        {
            Circle сircle = new Circle(4);
            Assert.AreEqual(25.13272, сircle.GetPerimeter());
        }

        //Calculating the area of a circle
        [TestMethod]
        public void TestCircleСalculatingArea()
        {
            Circle сircle = new Circle(4);
            Assert.AreEqual(50.26544, сircle.GetArea());
        }
    }
}
