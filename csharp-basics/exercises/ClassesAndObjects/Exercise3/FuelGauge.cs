using System;

namespace Exercise3
{
    class FuelGauge
    {
        public double _currentLiters { get; set; }
        public bool _full = false;
        public bool _empty = false;

        public void addFuel()
        {
            if (_currentLiters + 1 > 70)
            {
                Console.WriteLine("The car is full");
                _full = true;
            }
            else
            {
                _full = false;
                _currentLiters += 1;
            }
        }

        public void burningFuel()
        {
            if (_currentLiters - 1 <= 0)
            {
                Console.WriteLine("The cars tank is empty");
                _currentLiters -= 1;
                _empty = true;
            }
            else
            {
                _empty = false;
                _currentLiters -= 1;
            }
        }
    }
}
