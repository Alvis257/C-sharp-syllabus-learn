using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRace.Test
{
    [TestClass]
    public class LexusTest
    {
        private Car _target;

        [TestMethod]
        public void Lexus_StartEngine()
        {
            //Arrange
            _target = new Lexus();
            string expected = "Rrrrrrr.....";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Lexus_SpeedUp_50()
        {
            //Arrange
            _target = new Lexus();
            string expected = "50";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Lexus_SpeedUp_Then_SlowDown_Return_CurrentSpeed_30()
        {
            //Arrange
            _target = new Lexus();
            string expected = "30";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Lexus_UseNitrousOxideEngine_120()
        {
            //Arrange
            _target = new Lexus();
            string expected = "120";
            //Act
            if (_target is Boost _target2)
                _target2.UseNitrousOxideEngine();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
