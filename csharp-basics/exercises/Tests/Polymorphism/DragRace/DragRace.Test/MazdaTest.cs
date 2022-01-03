using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRace.Test
{
    [TestClass]
    public class MazdaTest
    {
        private Car _target;

        [TestMethod]
        public void Mazda_StartEngine()
        {
            //Arrange
            _target = new Mazda();
            string expected = "Vrum....Vrum....";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mazda_SpeedUp_50()
        {
            //Arrange
            _target = new Mazda();
            string expected = "50";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Mazda_SpeedUp_Then_SlowDown_Return_CurrentSpeed_30()
        {
            //Arrange
            _target = new Mazda();
            string expected = "30";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Mazda_UseNitrousOxideEngine_100()
        {
            //Arrange
            _target = new Mazda();
            string expected = "100";
            //Act
            if (_target is Boost _target2)
                _target2.UseNitrousOxideEngine();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
