using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;
using System;

namespace CalculateArea.Test
{
    [TestClass]
    public class CalculateAreaTest
    {
        private Geometry _target = new Geometry();

        [TestMethod]
        public void Test_AreaOfCircle_Should_Throw_Exception_When_Radius_Is_Negative()
        {
            //Arange
            int radius = -1;

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.AreaOfCircle(radius));
        }

        [TestMethod]
        public void Test_AreaOfCircle_Should_Be_A_Number_When_Radius_Positiv()
        {
            //Arange
            decimal radius = 10;
            double TestResult=62.8;

            //Assert
            Assert.AreEqual(TestResult,_target.AreaOfCircle(radius));
        }

        //Arange
        [DataRow(10, -20)]
        [DataRow(-10, 20)]
        [DataRow(-10, -20)]
        [TestMethod]
        public void Test_AreaOfRectangle_Should_Throw_Exception_When_Width_Or_Length_Is_Negative(double lengthParameter,double widthParameter)
        {
            //Arange
            decimal length = Convert.ToDecimal(lengthParameter);
            decimal width = Convert.ToDecimal(widthParameter);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.AreaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_AreaOfRectangle_should_be_A_Number_when_LengthAndWidth_Positive()
        {
            //Arange
            decimal length = 10;
            decimal width = 20;
            double testResult = 200;

            //Assert
            Assert.AreEqual(testResult, _target.AreaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_AreaOfTriangle_should_be_A_Number_when_LengthAndWidth_Positive()
        {
            //Arange
            decimal ground = 15;
            decimal height = 10;
            double testResult = 150;

            //Assert
            Assert.AreEqual(testResult, _target.AreaOfTriangle(ground, height));
        }

        //Arange
        [DataRow(15, -2)]
        [DataRow(-15, 2)]
        [DataRow(-15, -2)]
        [TestMethod]
        public void Test_AreaOfTriangle_Should_Throw_Exception_When_Ground_Or_Height_Is_Negative(double groundParameter,double heightParameter)
        {
            //Arange
            decimal ground = Convert.ToDecimal(groundParameter);
            decimal height = Convert.ToDecimal(heightParameter);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.AreaOfTriangle(ground, height));
        }

    }
}
