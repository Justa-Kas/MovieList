using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List
{
    class MovieSelection
    {
        public string Title { get; set;}
        public string Category { get; set; }
        public MovieSelection(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;

        }
    }
}
