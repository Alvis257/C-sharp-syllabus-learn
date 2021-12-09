using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie casino = new Movie("Casino Royale", "Eon Productions", "PG­13");
            Movie glass = new Movie("Glass", "Buena Vista International", "PG­13");
            Movie spider_Man = new Movie("Spider-Man", "Columbia Pictures");

            var movie = new List<Movie>
            {
                casino,
                glass,
                spider_Man,
            };
            var filtered = GetPG(movie.ToArray());

            foreach (var movies in filtered)
            {
                Console.WriteLine(movies.Display());
            }

            Console.ReadKey();
        }

        static Movie[] GetPG(Movie[] movies)
        {
            var filter = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie._raiting == "PG")
                {
                    filter.Add(movie);
                }
            }

            return filter.ToArray();
        }
    }
}
