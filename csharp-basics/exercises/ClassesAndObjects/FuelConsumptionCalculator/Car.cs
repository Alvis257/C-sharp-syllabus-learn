namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double _startKilometers;
        public double _endKilometers;
        public double _liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            return 0;
        }

        private double ConsumptionPer100Km()
        {
            return 0;
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
        }
    }
}
