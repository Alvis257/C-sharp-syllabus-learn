using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class ZebraTest
    {
        private Zebra _target = new Zebra("Zebra", "White And Black", 160, "Wild", 0);

        [TestMethod]
        public void Zebra_MakeSound_Should_Be_Bark()
        {
            //Arrange
            string expected = "Barks";

            //Act
            string result = _target.MakeSound();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("Meat")]
        [DataRow("Vegetable")]
        [TestMethod]
        public void Zebra_FoodType_Should_Be_True_When_Vegetable_And_Meat(string foodType)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = _target.FoodType(foodType);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_AnimalName_Should_Be_Zebra()
        {
            //Arrange
            string expected = "Zebra";

            //Act
            string result = _target.GetSetAnimalName;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_AnimalType_Should_Be_Grey()
        {
            //Arrange
            string expected = "White And Black";

            //Act
            string result = _target.GetSetAnimalType;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_AnimalWeight_Should_Be_160()
        {
            //Arrange
            double expected = 160;

            //Act
            double result = _target.GetSetAnimalWeigt;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_Region_Should_Be_wild()
        {
            //Arrange
            string expected = "Wild";

            //Act
            string result = _target.GetSetRegion;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_GetFood_Should_Be_0()
        {
            //Arrange
            int expected = 0;

            //Act
            int result = _target.GetSetFood;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zebra_SetFood_Should_be_3()
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
