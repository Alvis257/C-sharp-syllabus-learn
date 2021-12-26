namespace Hierarchy
{
    class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }

        public string ToString()
        {
            return "Vegetable";
        }
    }
}
