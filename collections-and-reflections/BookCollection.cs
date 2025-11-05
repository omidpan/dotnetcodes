using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_and_reflections
{
    public class BookCollection : IEnumerable, IEnumerator
    {
        private List<Book> books = new List<Book>();
        private int pointer = -1;
        public object Current
        {
            get
            {
                return books[pointer];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
           if(pointer < books.Count - 1)
            {
                pointer++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            pointer = -1;
        }
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }
    }
    }
