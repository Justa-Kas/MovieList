using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List
{
    class Movie
    {
        public static List<MovieSelection> MovieList = new List<MovieSelection>
        {
            new MovieSelection("Incredibles", "animated"),
            new MovieSelection("Her", "drama"),
            new MovieSelection("Knives Out", "drama"),
            new MovieSelection("Chappie", "scifi"),
            new MovieSelection("Tangled", "animated"),
            new MovieSelection("After Earth", "scifi"),
            new MovieSelection("Train to Busan", "horror"),
            new MovieSelection("Scream", "horror"),
            new MovieSelection("Avatar", "scifi"),
            new MovieSelection("The Platform", "horror"),
        };
       
        
        public static void MovieShower(string genreGiven)
        {
            foreach (MovieSelection m in MovieList)
            {
                if(genreGiven == m.Category)
                {
                    Console.WriteLine(m.Title);
                }
            }
            
        }
    }
}
