using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Getters_and_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Evans", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();

        }
    }
    class Movie
    {
        public string title;
        public string director;
        public string rating;// now can only be set by getters and setters, for security

        //constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating; //now only using the getters and setters values
        }

        public string Rating
        {
            get { return rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }

            }
        }




    }
}
