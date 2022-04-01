using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MyLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wrong argument")]
        public void Triangle_3_4_10Edges_ExceptionReturned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 10);

            //act

            //assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wrong argument")]
        public void Triangle_3_4_Minus5Edges_ExceptionReturned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, -5);

            //act

            //assert
        }

        [TestMethod()]
        public void CalculateArea_Triangle3_4_5_6Returned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double p = (3 + 4 + 5) / 2;
            double expected = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));

            //act
            double actual = triangle.CalculateArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void isOrthogonalTriangle_Triangle3_4_5_TrueReturned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            //act
            bool actual = triangle.isOrthogonalTriangle();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void isOrthogonalTriangle_Triangle4_4_4_FalseReturned()
        {
            //arrange
            Triangle triangle = new Triangle(4, 4, 4);
            bool expected = false;

            //act
            bool actual = triangle.isOrthogonalTriangle();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}