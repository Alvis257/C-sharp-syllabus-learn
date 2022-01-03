namespace Exercise5
{
    public class Date
    {
        private int a_month;
        private int a_day;
        private int a_year;

        public Date(int day, int month, int year)
        {
            a_month = month;
            a_day = day;
            a_year = year;
        }

        public string DisplayDate()
        {
            return $"{a_month}/{a_day}/{a_year}";
        }
    }
}
