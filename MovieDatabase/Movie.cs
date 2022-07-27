using System;
namespace MovieDatabase
{
    public class Movie
    {

        //Constructor
        public Movie(string name, string genre, string synopsis, int genreCode, int yearReleased, int runTime)
        {
            Name = name;
            Genre = genre;
            Synopsis = synopsis;
            GenreCode = genreCode;
            YearReleased = yearReleased;
            RunTime = runTime;

        }
        public Movie(string genre, int genreCode)
        {

            Genre = genre;
            GenreCode = genreCode;
        }

        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Synopsis { get; set; }
        public int GenreCode { get; set; }
        public int YearReleased { get; set; }
        public int RunTime { get; set; }
        public List<Movie> GetMovie { get; set; }

        //Method to display movie details
        public void displayMovieDetails()
        {
            Console.WriteLine(String.Format("{0,-18}{1,-15}", "Name: ", Name));
            Console.WriteLine(String.Format("{0,-18}{1,-15}", "Year Released: ", YearReleased));
            Console.WriteLine(String.Format("{0,-18}{1,-15}", "Run Time: ", RunTime + "m"));
            Console.WriteLine(String.Format("{0,-18}{1,-15}", "Synopsis: ", Synopsis + "\n\n"));
        }
    }
}