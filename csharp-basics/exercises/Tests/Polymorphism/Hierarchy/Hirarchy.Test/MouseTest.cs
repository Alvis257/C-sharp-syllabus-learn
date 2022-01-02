using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class MouseTest
    {
        private Mouse _target = new Mouse("Mouse", "Gray", 0.3, "Box", 0);

        [TestMethod]
        public void Mouse_MakeSound_Should_Be_Scratching()
        {
            //Arrange
            string expected = "Scratching";

            //Act
            string result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_FoodType_Should_Be_False_When_Meat()
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = _target.FoodType("Meat");

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_FoodType_Should_Be_True_When_Vegetable()
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = _target.FoodType("Vegetable");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_AnimalName_Should_Be_Mouse()
        {
            //Arrange
            string expected = "Mouse";

            //Act
            string result = _target.GetSetAnimalName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_AnimalType_Should_Be_Grey()
        {
            //Arrange
            string expected = "Gray";

            //Act
            string result = _target.GetSetAnimalType;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_AnimalWeight_Should_Be_0_Point_3()
        {
            //Arrange
            double expected = 0.3;

            //Act
            double result = _target.GetSetAnimalWeigt;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_Region_Should_Be_Box()
        {
            //Arrange
            string expected = "Box";

            //Act
            string result = _target.GetSetRegion;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_GetFood_Should_Be_0()
        {
            //Arrange
            int expected = 0;

            //Act
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Mouse_SetFood_Should_be_3()
        {
            //Arrange
            Food food = new Vegetable(3);
            int expected = 3;

            //Act
            _target.Eat(food);
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
