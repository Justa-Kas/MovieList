using System;

namespace Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string genreGiven;
            bool willItLoop = true;
            while (willItLoop)
            {
                Console.WriteLine("Hey there, welcome to the movie list.");
                while (true)
                {
                    Console.WriteLine("Please enter a genre(scifi, horror, animated, or drama)");
                    genreGiven = (Console.ReadLine());
                    if (!(genreGiven == "scifi" || genreGiven == "drama" || genreGiven == "horror" || genreGiven == "animated"))
                    {
                        Console.Write("That's not a valid genre. ");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Here are the movies listed in that genre. \n");
                Movie.MovieShower(genreGiven);

                while (true)
                {
                    Console.WriteLine("Do you want to check out a different genre? (yes or no)");
                    string loopAnswer = (Console.ReadLine());
                    if (loopAnswer == "yes")
                    {
                        break;
                    }
                    else if (loopAnswer == "no")
                    {
                        Console.WriteLine("Goodbye.");
                        willItLoop = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That's not a valid input");
                    }
                }
            }
        }
    }
}

