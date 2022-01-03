using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise_1;

namespace Exercise_1Test
{
    [TestClass]
    public class Exercise1Test
    {
        [TestMethod]
        public void Number_sum_is_Equel_To_15_Result_True()
        {
            //Arange
            int number1 = 10;
            int number2 = 5;
            //Act , Assert
            Assert.IsTrue(CheckNumbers.CheckForNumber15(number1, number2));
        }

        [TestMethod]
        public void Number_Diferenc_is_Equel_To_15_Result_True()
        {
            //Arange
            int number1 = 20;
            int number2 = 5;
            //Act , Assert
            Assert.IsTrue(CheckNumbers.CheckForNumber15(number1, number2));
        }

        [TestMethod]
        public void Number_is_Equel_To_15_Result_True()
        {
            //Arange
            int number1 = 20;
            int number2 = 15;
            //Act , Assert
            Assert.IsTrue(CheckNumbers.CheckForNumber15(number1, number2));
        }

        [TestMethod]
        public void Number_is_NotEquel_To_15_Result_False()
        {
            //Arange
            int number1 = 2;
            int number2 = 1;
            //Act , Assert
            Assert.IsFalse(CheckNumbers.CheckForNumber15(number1, number2));
        }
    }
}
