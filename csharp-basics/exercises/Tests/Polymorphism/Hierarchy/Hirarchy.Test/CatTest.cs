using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class CatTest
    {
        private Cat _target = new Cat("Cat", "Gray", 1.1, 0, "Home", "Persian");

        [TestMethod]
        public void Cat_MakeSound_Should_Be_Meowww()
        {
            //Arrange
            string expected = "Meowwww";

            //Act
            string result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_Breed_Should_Be_Persian()
        {
            //Arrange
            string expected = "Persian";

            //Act
            string result = _target.GetSetBreed;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_AnimalName_Should_Be_Cat()
        {
            //Arrange
            string expected = "Cat";

            //Act
            string result = _target.GetSetAnimalName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_AnimalType_Should_Be_Grey()
        {
            //Arrange
            string expected = "Gray";

            //Act
            string result = _target.GetSetAnimalType;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_AnimalWeight_Should_Be_1_Point_1()
        {
            //Arrange
            double expected = 1.1;

            //Act
            double result = _target.GetSetAnimalWeigt;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_Region_Should_Be_Home()
        {
            //Arrange
            string expected = "Home";

            //Act
            string result = _target.GetSetRegion;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_GetFood_Should_Be_0()
        {
            //Arrange
            int expected = 0;

            //Act
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cat_SetFood_Should_be_5()
        {
            //Arrange
            Food food = new Vegetable(5);
            int expected = 5;

            //Act
            _target.Eat(food);
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
