using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    class Movie
    {

        public int Length { get; private set; }
        public string Title { get; private set; }
        public MovieGenre Genre { get; private set; }
        public List<string> Cast { get; private set; }
        public Movie(string name, int length)
        {
            Title = name;
            Length = length;
            Cast = new List<string>();
        }
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(MovieGenre genre)
        {
            Genre = genre;

        }
        public override string ToString()
        {
            string actors = string.Join(",", Cast);
            return string.Format("{0} {1} {2}", actors, Title, Genre);
        }
    }
}
