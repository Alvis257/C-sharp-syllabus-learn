using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GravityCalculator.Test
{
    [TestClass]
    public class GravityCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double expected = -490.5;
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            var testPosition = new Calculator();

            //Assert
            Assert.AreEqual(expected, testPosition.Position(gravity, fallingTime, initialVelocity, initialPosition));

        }
    }
}
