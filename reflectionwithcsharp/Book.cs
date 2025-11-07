using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionwithcsharp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book() { }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }

        public string GetSummary()
        {
            return $"{Title} by {Author}";
        }
    }
}
