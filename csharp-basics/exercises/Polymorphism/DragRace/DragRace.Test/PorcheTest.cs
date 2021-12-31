using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRace.Test
{
    [TestClass]
    public class PorcheTest
    {
        private Car _target;

        [TestMethod]
        public void Porche_StartEngine()
        {
            //Arrange
            _target = new Porche();
            string expected = "Brummm.....";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Porche_SpeedUp_100()
        {
            //Arrange
            _target = new Porche();
            string expected = "100";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Porche_SpeedUp_Then_SlowDown_Return_CurrentSpeed_80()
        {
            //Arrange
            _target = new Porche();
            string expected = "80";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
