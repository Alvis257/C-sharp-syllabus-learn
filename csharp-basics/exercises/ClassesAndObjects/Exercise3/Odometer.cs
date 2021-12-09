namespace Exercise3
{
    class Odometer
    {
        public int _currentmilage;

        public Odometer(FuelGauge fuel)
        {
            _fuel = fuel;
        }

        private FuelGauge _fuel;

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
    }
}
