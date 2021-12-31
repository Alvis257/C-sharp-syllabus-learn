using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Test
{
    [TestClass]
    public class TeslaTest
    {
        private Car _target;

        [TestMethod]
        public void Tesla_StartEngine()
        {
            //Arrange
            _target = new Tesla();
            string expected = "-- silence ---";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tesla_SpeedUp_80()
        {
            //Arrange
            _target = new Tesla();
            string expected = "80";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Tesla_SpeedUp_Then_SlowDown_Return_CurrentSpeed_40()
        {
            //Arrange
            _target = new Tesla();
            string expected = "40";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
