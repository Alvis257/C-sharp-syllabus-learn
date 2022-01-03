using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Product_NewValueInput_Through_PrintProduct_Should_Return_Products()
        {
            //Arrange
            string[] name = new string[] {"Jolo", "Lol"};
            double[] price = new double[] {2.35, 2.45};
            int[] amount = new int[] {20, 21};
            var target = new Product(name, price, amount);

            //Act
            string[] testDisplayProduct = target.PrintProduct();

            //Assert
            for (int i = 0; i < testDisplayProduct.Length; i++)
            {
                Assert.AreEqual($"{i + 1} Name:{name[i]} Price:{price[i]} Amount:{amount[i]}", testDisplayProduct[i]);
            }
        }

        [TestMethod]
        public void ChangePrice_Should_Return_New_Price()
        {
            //Arrange
            string[] name = new string[] {"Jolo", "Lol"};
            double[] price = new double[] {2.35, 2.45};
            int[] amount = new int[] {20, 21};
            var target = new Product(name, price, amount);
            double expected = 6.60;

            //Assert
            Assert.AreEqual(expected, target.ChangePrice(1, 6.60));
        }

        [TestMethod]
        public void ChangeAmount_Should_Return_New_Amount()
        {
            //Arrange
            string[] name = new string[] {"Jolo", "Lol"};
            double[] price = new double[] {2.35, 2.45};
            int[] amount = new int[] {20, 21};
            var target = new Product(name, price, amount);
            double expected = 3;

            //Assert
            Assert.AreEqual(expected, target.ChangeAmount(1, 3));
        }
    }
}
