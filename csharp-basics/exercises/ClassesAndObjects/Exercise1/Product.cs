using System;

namespace Exercise1
{
    class Product
    {
        private string[] _name;
        private double[] _priceAtStart;
        private int[] _amountAtStart;

        public Product(string[] name, double[] priceAtStart, int[] amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            for (int i = 0; i < _name.Length; i++)
            {
                Console.WriteLine($"{i + 1} ,{_name[i]}, price {_priceAtStart[i]}, amount {_amountAtStart[i]}");
            }
        }
    }
}
