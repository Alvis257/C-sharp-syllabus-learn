namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double _startKilometers;
        public double _milage;
        public double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (_milage - _startKilometers) / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _milage = mileage;
            _liters = liters;
        }
    }
}
