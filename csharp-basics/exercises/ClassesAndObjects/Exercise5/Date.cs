namespace Exercise5
{
    public class Date
    {
        private int _month;
        private int _day;
        private int _year;

        public Date(int day, int month, int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }

        public string DisplayDate()
        {
            return $"{_month}/{_day}/{_year}";
        }
    }
}
