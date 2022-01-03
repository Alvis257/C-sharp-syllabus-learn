namespace Hierarchy
{
    public abstract class Food
    {
        private int _quantaty;

        public Food(int quantaty)
        {
            _quantaty = quantaty;
        }

        public int GetSetQuantaty
        {
            get { return _quantaty; }
            set => _quantaty = value;
        }

        public abstract string ToString();
    }
}
