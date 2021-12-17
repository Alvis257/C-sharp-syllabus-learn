using System;

namespace Exercise3
{
    class Odometer
    {
        private int _currentmilage;
        private FuelGauge _fuel;

        public Odometer(FuelGauge fuel)
        {
            _fuel = fuel;
        }

        public void Milgae()
        {
            if (_currentmilage + 1 != 1000000)
            {
                _currentmilage += 1;
            }
            else
            {
                _currentmilage = 0;
            }

            if (_currentmilage % 10 == 0)
            {
                _fuel.burningFuel();
            }
        }

        public void DisplayAll()
        {
            Console.WriteLine($"Millage: {_currentmilage} " +
                              $"Fuel tank: {_fuel.DisplayLiters()}");
        }
    }
}
