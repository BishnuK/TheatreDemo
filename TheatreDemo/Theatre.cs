using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    class Theatre
    {
        public List<Show> Shows { get; private set; }
        public string Name { get; private set; }
        public Theatre(string name)
        {
            Name = name;
            Shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine("\n\nAll Avaible Movie Shows \n");
            Console.WriteLine("**************************************************************");
            foreach (var item in Shows)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintShows(MovieGenre genre)
        {
            Console.WriteLine("\n\n Movie Shows and Genre Type \n");
            Console.WriteLine("**************************************************************");
            foreach (var item in Shows)
            {
                if (item.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void PrintShows(MovieDay day)
        {
            Console.WriteLine("\n\n Movie Shows and Days \n");
            Console.WriteLine("**************************************************************");
            foreach (var item in Shows)
            {
                if (item.Day == day)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine("\n\nAll Movie Shows and Movie Time\n");
            Console.WriteLine("**************************************************************");
            foreach (var item in Shows)
            {
                if (item.Time == time)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void PrintShows(string actor)
        {
            Console.WriteLine("\n\nMovie and Actors \n");
            Console.WriteLine("**************************************************************");
            foreach (var item in Shows)
            {
                if (item.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
