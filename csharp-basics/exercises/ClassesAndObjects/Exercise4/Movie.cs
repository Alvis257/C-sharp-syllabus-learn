using System;

namespace Exercise4
{
    class Movie
    {
        public Movie(string title, string studio, string raiting)
        {
            _title = title;
            _studio = studio;
            _raiting = raiting;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _raiting = "PG";
        }

        public string Display()
        {
            return $"{_title} {_studio} {_raiting}";
        }

        private string _title { get; set; }
        private string _studio { get; set; }
        public string _raiting { get; private set; }

    }
}
