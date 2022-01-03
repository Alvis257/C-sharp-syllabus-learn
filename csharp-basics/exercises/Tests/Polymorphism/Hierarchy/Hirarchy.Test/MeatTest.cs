using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;

namespace Hirarchy.Test
{
    [TestClass]
    public class MeatTest
    {
        private Food _target;

        [TestMethod]
        public void Food_Meat_Add_Quantity_Should_Be_4()
        {
            //Arrange
            int expected = 4;
            _target = new Meat(4);

            //Assert
            Assert.AreEqual(expected, _target.GetSetQuantaty);
        }

        [TestMethod]
        public void Vegetable_ToString_Should_Be_Meat()
        {
            //Arrange
            string expected = "Meat";
            _target = new Meat(3);
            string result = _target.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
