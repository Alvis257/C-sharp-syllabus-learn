using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Test
{
    [TestClass]
    public class BMWTest
    {
        private Car _target;
        

        [TestMethod]
        public void Bmw_StartEngine()
        {
            //Arrange
            _target = new Bmw();
            string expected = "Rrrrrrr.....";

            //Act
            string result = _target.StartEngine();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Bmw_SpeedUp_70()
        {
            //Arrange
            _target = new Bmw();
            string expected = "70";
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [TestMethod]
        public void Bmw_SpeedUp_Then_SlowDown_Return_CurrentSpeed_60()
        {
            //Arrange
            _target = new Bmw();
            string expected = "60";
            //Act
            _target.SpeedUp();
            _target.SlowDown();
            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
