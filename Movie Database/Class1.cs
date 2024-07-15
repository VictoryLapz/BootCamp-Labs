using MovieLab;


    List<Movie> movieList = new List<Movie>
{
    new Movie("Friday", "Comedy"),
    new Movie("Boss Baby", "Children"),
    new Movie("New Jack City", "Drama"),
    new Movie("Halloween", "Horror"),
    new Movie("Freaky Friday", "Children"),
    new Movie("Dobuel 07", "Action"),
    new Movie("Rush Hour", "Comedy"),
    new Movie("Life", "Comedy"),
    new Movie("Taken", "Drama"),
    new Movie("Top Gun", "Action"),
};

do
{

    Console.WriteLine("Welcome to the Movie List Application");
    Console.WriteLine("There are 10 movies in this list.");
    Console.WriteLine("What category are you interested in?");
    Console.WriteLine();

    string userSelection = Console.ReadLine();

    foreach (Movie movie in movieList)
    {
        if (movie.Category == userSelection)
        {
            Console.WriteLine($"{movie.Title}");
        }

    }
    Console.WriteLine("Would you like to continue? Y/N");
    string Response = Console.ReadLine().ToLower();
    if (Response != "y")
    {
        break;
    }
}while (true);







