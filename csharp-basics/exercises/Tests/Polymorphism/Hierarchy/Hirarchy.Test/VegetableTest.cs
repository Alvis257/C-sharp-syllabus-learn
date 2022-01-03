using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class VegetableTest
    {
        private Food _target;

        [TestMethod]
        public void Food_Vegetable_Add_Quantity_Should_Be_4()
        {
            //Arrange
            int expected = 4;
            _target = new Vegetable(4);

            //Assert
            Assert.AreEqual(expected, _target.GetSetQuantaty);
        }

        [TestMethod]
        public void Vegetable_ToString_Should_Be_Vegetable()
        {
            //Arrange
            string expected = "Vegetable";
            _target = new Vegetable(3);
            string result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
