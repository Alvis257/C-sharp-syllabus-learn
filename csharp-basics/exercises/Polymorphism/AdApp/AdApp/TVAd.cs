namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private int _rate;
        private bool _airing;

        public TVAd(int fee, int seconds, int rate, bool airing) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _airing = airing;
        }

        public new int Cost()
        {
            if (_airing == true)
            {
                return base.Cost() + _seconds * _rate * 2;
            }

            return base.Cost() + _seconds * _rate;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}