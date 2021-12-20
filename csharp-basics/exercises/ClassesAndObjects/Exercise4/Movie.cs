namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        public string _rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string Display()
        {
            return $"{_title} {_studio} {_rating}";
        }
    }
}
