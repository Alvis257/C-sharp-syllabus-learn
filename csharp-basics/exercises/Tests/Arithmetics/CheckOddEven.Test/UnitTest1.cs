using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckOddEven.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Check_Even()
        {
            //Arrange
            int number = 19;
            string resultText = OddEven.IsEven(number);

            //Assert
            Assert.AreEqual("Odd Number", resultText);
        }

        [TestMethod]
        public void Check_Odd()
        {
            //Arrange
            int number = 20;
            string resultText = OddEven.IsEven(number);

            //Assert
            Assert.AreEqual("Even Number", resultText);
        }
    }
}
