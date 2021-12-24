namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(int fee, int numDays, int rate, bool primLocation) : base(fee)
        {
            _numDays = numDays;
            _rate = rate;
            _primeLocation = primLocation;
        }

        public new int Cost()
        {
            if (_primeLocation == true)
            {
                return (int) (base.Cost() + _numDays * _rate * 0.5);
            }

            return base.Cost() + _numDays * _rate;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}