using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class TigerTest
    {
        //Arrange
        private Tiger _target = new Tiger("Tiger", "Yellow", 200, "Wild", 0);

        [TestMethod]
        public void Tiger_MakeSound_Should_Be_ROAAR()
        {
            //Arrange
            string expected = "ROAAR!!!";

            //Act
            string result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_FoodType_Should_Be_False_When_Vegetable()
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = _target.FoodType("Vegetable");

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_FoodType_Should_Be_True_When_Meat()
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = _target.FoodType("Meat");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_AnimalName_Should_Be_Tiger()
        {
            //Arrange
            string expected = "Tiger";

            //Act
            string result = _target.GetSetAnimalName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_AnimalType_Should_Be_Yellow()
        {
            //Arrange
            string expected = "Yellow";

            //Act
            string result = _target.GetSetAnimalType;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_AnimalWeight_Should_Be_200()
        {
            //Arrange
            double expected = 200;

            //Act
            double result = _target.GetSetAnimalWeigt;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_Region_Should_Be_Wild()
        {
            //Arrange
            string expected = "Wild";

            //Act
            string result = _target.GetSetRegion;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_GetFood_Should_Be_0()
        {
            //Arrange
            int expected = 0;

            //Act
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Tiger_SetFood_Should_be_3()
        {
            //Arrange
            Food food = new Meat(3);
            int expected = 3;

            //Act
            _target.Eat(food);
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
