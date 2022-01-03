namespace Exercise_1
{
    public class CheckNumbers
    {
        public static bool CheckForNumber15(int number1, int number2)
        {
            if (number1 == 15 || number2 == 15)
            {
                return true;

            }
            else if (number1 + number2 == 15 || number1 - number2 == 15)
            {
                return true;
            }

            return false;
        }
    }
}
