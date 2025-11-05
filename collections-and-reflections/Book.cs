using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_and_reflections
{
    public class Book
    {
        public Book() { }
        public Book(string title,string author,int yearPublished) { 
            this.Title= title;
            this.Author= author;
            this.YearPublished= yearPublished;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author}, published in {YearPublished}";
        }
    }
}
