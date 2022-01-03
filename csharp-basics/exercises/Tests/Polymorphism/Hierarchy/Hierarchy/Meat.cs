namespace Hierarchy
{
    public class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return "Meat";
        }
    }
}
