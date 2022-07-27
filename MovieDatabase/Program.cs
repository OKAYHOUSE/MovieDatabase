//MovieDatabase
//Application stores a list of 10 movies and displays them by category.
//main
using MovieDatabase;

Console.WriteLine("\nWelcome to the Movie Database!");

//Instantiate and create an objects of the Movie class
Movie movieOne = new Movie("Eternals: Immortal Heroes", "Sci-Fi", "Eternals: Immortal Heroes, " +
   "stars unite to defend humanity...", 1, 2021, 158);
Movie movieTwo = new Movie("Everything Everywhere", "Sci-Fi", "Interdimensional rupture unravels...", 1, 2022, 132);
Movie movieThree = new Movie("The Sea Best", "Animation", "In an era when terrifying beasts roamed...", 2, 2022, 115);
Movie movieFour = new Movie("Minnions: The Rise of Gru", "Animation", "In the heart of the 1970s, amid...", 2, 2022, 87);
Movie movieFive = new Movie("Top Gun: Maverick", "Action", "After more than thirty years of service...", 3, 2022, 131);
Movie movieSix = new Movie("The Gray Man", "Action", "When the CIA's top asset uncovers agency... ", 3, 2022, 129);
Movie movieSeven = new Movie("The Black Phone", "Horror", "Finney, a shy but clever 13-year-old...", 4, 2022, 102);
Movie movieEight = new Movie("The Innocents", "Horror", "Terror strikes when a group of Nordic...", 4, 2022, 118);
Movie movieNine = new Movie("Hustle", "Drama", "Stanley Sugerman's love for basketball is... ", 5, 2022, 118);
Movie movieTen = new Movie("Happening", "Drama", "France, 1963. Anne is a bright young student...", 5, 2022, 110);

//Add movies to a list
List<Movie> MovieInventory = new List<Movie>() { movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven, movieEight, movieNine, movieTen };

//Instantiate and create an object of Genres and Codes
Movie genreThree = new Movie("Action", 3);
Movie genreTwo = new Movie("Animation", 2);
Movie genreFive = new Movie("Drama", 5);
Movie genreFour = new Movie("Horror", 4);
Movie genreOne = new Movie("Sci-Fi", 1);

//Add genres to a list
List<Movie> MovieGenre = new List<Movie>() { genreOne, genreTwo, genreThree, genreFour, genreFive };

int userChoice = 0;

//Program loop
bool runProgram = true;
while (runProgram)
{
    //Display Genres and Associated Codes
    //MovieGenre.ForEach(m => m.displayGenreCodes()); - not sure why this did not work
    Console.Clear();
    MovieGenre.OrderBy(x => x.Genre)
        .ToList()
        .ForEach(y => Console.WriteLine($"{y.GenreCode}. {y.Genre}"));

    //Loop to validate selected genre code is in range
    while (true)
    {
        //Get user's choice and validate genre code entry is a number
        userChoice = Validator.Validator.GetUserNumberInt("\nWhat Genre are you interested in? Enter the associated number (1-5): ");
        if (Validator.Validator.InRange(userChoice, 1, 5))
        {
            break;
        }
        else { Console.Write("\nInvalid entry. Please enter a number between (1-5).\n");
        continue; }
    }
    //Display results
    //MovieInventory.Where(x => x.GenreCode == userChoice).ToLookup
    Console.Clear();

    Console.WriteLine($"Here are the movies: \n");
    MovieInventory.Where(x => x.GenreCode == userChoice)
        .OrderBy(x => x.Name).ToList()
        .ForEach(x => x.displayMovieDetails());

    //Get user's choice to continue or quit program
    runProgram = Validator.Validator.GetContinue();
}