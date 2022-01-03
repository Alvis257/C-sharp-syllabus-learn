
namespace CheckCozaLozaWoza
{
    public class CheckCozaLozaWoza
    {
        public  string CozLozWoz(int pozition)
        {
            if (pozition % 3 == 0 && pozition % 5 == 0 && pozition % 7 == 0)
            {
                return " CozaLozaWoza ";
            }
            else if (pozition % 3 == 0 && pozition % 5 == 0)
            {
                return " CozaLoza ";
            }
            else if (pozition % 3 == 0 && pozition % 7 == 0)
            {
                return " CozaWoza ";
            }
            else if (pozition % 5 == 0 && pozition % 7 == 0)
            {
                return " LozaWoza ";
            }
            else if (pozition % 3 == 0)
            {
                return " Coza ";
            }
            else if (pozition % 5 == 0)
            {
                return " Loza ";
            }
            else if (pozition % 7 == 0)
            {
                return " Woza ";
            }
            else return pozition.ToString();
        }
    }
}
