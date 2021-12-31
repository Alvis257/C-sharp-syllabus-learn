using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckCozaLozaWoza.Test
{
    [TestClass]
    public class CozaLozaWozaTest
    {
        //Arange
        private CheckCozaLozaWoza _target = new CheckCozaLozaWoza();
        [DataRow(" Loza ",10)]
        [DataRow(" Coza ", 3)]
        [DataRow(" Woza ", 7)]
        [DataRow(" CozaLoza ", 15)]
        [DataRow(" CozaWoza ", 21)]
        [DataRow(" CozaLozaWoza ", 105)]

        [TestMethod]
        public void Test_CozaLozaWoza_Return_Correct_String_At_Given_Value(string expected, int position)
        {
            //Act
            string s = _target.CozLozWoz(position);

            //Assert
            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void Test_CozaLozaWoza_Return_Multiple_String()
        {
            //Arange
            string s = string.Empty;

            //Act
            for (int position = 1; position <= 20; position++)
                s += _target.CozLozWoz(position)+" ";

            //Assert
            Assert.AreEqual("1 2  Coza  4  Loza   Coza   Woza  8  Coza   Loza  11 "+
                " Coza  13  Woza   CozaLoza  16 17  Coza  19  Loza  ",s);
        }
    }
}
