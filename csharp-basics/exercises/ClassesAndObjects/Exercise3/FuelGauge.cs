using System;

namespace Exercise3
{
    class FuelGauge
    {
        private double _currentLiters;
        private bool _full = false;
        private bool _empty = false;

        public void AddFuel()
        {
            if (_currentLiters + 1 > 70)
            {
                Console.WriteLine("The car is full");
                _full = true;
            }
            else
            {
                _currentLiters += 1;
            }
        }

        public bool IsFull()
        {
            if (_full || _empty)
            {
                return false;
            }

            return true;
        }

        public void ResetBoolValue()
        {
            _full = false;
            _empty = false;
        }

        public double DisplayLiters()
        {
            return _currentLiters;
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
                _currentLiters -= 1;
            }
        }
    }
}
