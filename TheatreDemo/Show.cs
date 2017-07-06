using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    class Show
    {
        public double Price { get; private set; }
        public MovieDay Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }
        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            Price = price;
            Day = day;
            Movie = movie;
            Time = time;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2:c} {3}", Movie, Day, Price, Time);
        }
    }
}
