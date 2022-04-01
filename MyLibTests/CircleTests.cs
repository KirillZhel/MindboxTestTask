using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateArea_Circle5Radius_AreaReturned()
        {
            //arrange
            Circle circle = new Circle(5);
            double expected = Math.PI * 5 * 5;

            //act
            double actual = circle.CalculateArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wrong argument")]
        public void Circle_Minus5Radius_ExceptionReturned()
        {
            //arrange
            Circle circle = new Circle(-5);
            //act

            //assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wrong argument")]
        public void Circle_0Radius_ExceptionReturned()
        {
            //arrange
            Circle circle = new Circle(0);

            //act

            //assert
        }
    }
}