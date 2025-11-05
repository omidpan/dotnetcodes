using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_and_reflections
{
    public class BookFactory
    {
        public static Book CreateBook(string title, string author, int yearPublished)
        {
            Book book= new Book();
            book.Title = title;
            book.Author = author;
            book.YearPublished = yearPublished;
            return book;
        }
    }
}
