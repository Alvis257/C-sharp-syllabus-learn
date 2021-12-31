namespace Exercise1
{
    public class Product
    {
        private string[] _productName;
        private double[] _productPrice;
        private int[] _ProductAmount;

        public Product(string[] name, double[] priceAtStart, int[] amountAtStart)
        {
            _productName = name;
            _productPrice = priceAtStart;
            _ProductAmount = amountAtStart;
        }

        public double ChangePrice(int count, double newPrice)
        {
            return _productPrice[count - 1] = newPrice;
        }

        public double ChangeAmount(int count, int newAmount)
        {
            return _ProductAmount[count - 1] = newAmount;
        }

        public string[] PrintProduct()
        {
            string[] displayContainer = new string[_productName.Length];
            for (int i = 0; i < _productName.Length; i++)
            {
                displayContainer[i] = string.Join(" ",
                    $"{i + 1} Name:{_productName[i]} Price:{_productPrice[i]} Amount:{_ProductAmount[i]}");
            }

            return displayContainer;
        }
    }
}
