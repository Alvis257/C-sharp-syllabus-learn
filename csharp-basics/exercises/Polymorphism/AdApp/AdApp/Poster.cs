namespace AdApp
{
    class Poster : Advert
    {
        private int _column;
        private int _rate;
        private int _row;
        private int _copyQuantity;

        public Poster(int fee, int column, int row, int copyQuantity, int rate) : base(fee)
        {
            _column = column;
            _rate = rate;
            _row = row;
            _copyQuantity = copyQuantity;
        }

        private new int Cost()
        {
            var fee = base.Cost() + _column + _row + (_copyQuantity * _rate);
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
