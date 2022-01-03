using Exercise__8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise_8.Test
{
    [TestClass]
    public class Exercise_8Test
    {
        //Arrange
        private CalculatePay _target = new CalculatePay();
        [DataRow(0,61,8)]
        [DataRow(0, 40, 3)]
        [DataRow(322,35,9.2f)]
        [DataRow(464.6f, 47, 9.2f)]

        [TestMethod]
        public void TestMethod1(float expected, float employeeHour ,float employeeBasePay)
        {
            //Act
            var testResult =_target.CauculatePayEmployee(employeeHour, employeeBasePay);

            //Assert
            Assert.AreEqual(expected, testResult);
        }
    }
}
