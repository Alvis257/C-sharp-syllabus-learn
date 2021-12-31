using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DragRace;

namespace DragRace.Test
{
    [TestClass]
    public class AudiTest
    {
        private Car _target;

        [TestMethod]
        public void Audi_StartEngine()
        {
            //Arrange
            _target = new Audi();
            string expected = "Rrrrrrr.....";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Audi_SpeedUp_70()
        {
            //Arrange
            _target = new Audi();
            string expected = "70";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected,_target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Audi_SpeedUp_Then_SlowDown_Return_CurrentSpeed_30()
        {
            //Arrange
            _target = new Audi();
            string expected = "30";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
