using System;
using System.Collections;
using System.Collections.Generic;


namespace collections_and_reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Polymorphism Example
             */


            //Animal myDog = new Dog();
            //Animal myCat = new Cat();


            ////Dynamic binding
            //myDog.MakeSound(); // Output: Dog barks
            //myCat.MakeSound(); // Output: Cat meows




            //Shape polymorphism (use Base class reference to refer derived class object)
            //Shape[] shapes = new Shape[3];
            //shapes[0] = new Circle();
            //shapes[1] = new Rectangle();
            //shapes[2] = new Triangle();

            ////dynamic binding and iteration
            //foreach (Shape shape in shapes)
            //{
            //    shape.Draw();
            //    Console.WriteLine("<br>");
            //}


            ////ArrayList example
            //ArrayList itmes = new ArrayList();
            //string str = "Hello World";
            //int x = 7;
            //DateTime d =DateTime.Parse("8-oct-2020");
            //itmes.Add(str);
            //itmes.Add(x);
            //itmes.Add(d);

            //foreach (object o in itmes)
            //{
            //    Console.WriteLine(o);
            //    Console.WriteLine("<br>");
            //}



            //// Collections with Dictionary
            //Dictionary<string, string> students = new Dictionary<string, string>();
            //students.Add("1", "Alice");
            //students.Add("2", "Bob");
            //students.Add("3", "Charlie");

            //foreach (KeyValuePair<string, string> kvp in students)
            //{
            //    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            //}

            //// Access value by key
            //Console.WriteLine(students["2"]);  // Output: Bob



            //    //HashTable from System.Collections (non-generic collection)

            //    Hashtable teachers = new Hashtable();
            //    teachers.Add(1, "Alice");
            //    teachers.Add(2, "Bob");
            //    teachers.Add(3, "Charlie");

            //    foreach (DictionaryEntry entry in teachers)
            //    {
            //        Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            //    }

            //    // Access value by key
            //    Console.WriteLine(teachers[2]);  // Output: Bob




            ////Stack Example

            //Stack<string> books = new Stack<string>();

            //// Push elements (add to the top)
            //books.Push("C# Basics");
            //books.Push("OOP Concepts");
            //books.Push("ASP.NET Core");

            //// Peek (see the top element without removing)
            //Console.WriteLine("Top book: " + books.Peek());

            //// Pop elements (remove from the top)
            //Console.WriteLine("Removed: " + books.Pop());
            //Console.WriteLine("Removed: " + books.Pop());

            //Console.WriteLine("\nRemaining stack:");
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            Stack booksNoGeneric = new Stack();

            //// Push elements
            //booksNoGeneric.Push("C# Basics");
            //booksNoGeneric.Push(101);       // different data type (allowed)
            //booksNoGeneric.Push(true);

            //// Peek
            //Console.WriteLine("Top: " + booksNoGeneric.Peek());

            //// Pop
            //Console.WriteLine("Removed: " + booksNoGeneric.Pop());

            //Console.WriteLine("\nRemaining items:");
            //foreach (var item in booksNoGeneric)
            //{
            //    Console.WriteLine(item);
            //}

            // Queue Example

           // Queue<string> customers = new Queue<string>();

           // // Enqueue (add items)
           // customers.Enqueue("Alice");
           // customers.Enqueue("Bob");
           // customers.Enqueue("Charlie");

           // Console.WriteLine("First in line: " + customers.Peek());

           // // Dequeue (remove first item)
           // Console.WriteLine("Served: " + customers.Dequeue());
           // Console.WriteLine("Served: " + customers.Dequeue());

           // Console.WriteLine("\nRemaining in queue:");
           // foreach (string customer in customers)
           // {
           //     Console.WriteLine(customer);
           // }

           // Console.WriteLine($"\nTotal waiting: {customers.Count}");


           // //No generic Queue

           // Queue q = new Queue();

           // // Enqueue (add items)
           // q.Enqueue("Alice");
           // q.Enqueue(42);
           // q.Enqueue(true);

           // Console.WriteLine("First item: " + q.Peek());

           // // Dequeue
           // Console.WriteLine("Removed: " + q.Dequeue());

           // Console.WriteLine("\nRemaining items:");
           // foreach (var item in q)
           // {
           //     Console.WriteLine(item);
           // }


           // //SortedList Example
           // // Create a SortedList with int keys and string values
           // SortedList<int, string> students = new SortedList<int, string>();

           // // Add elements (keys are automatically sorted)
           // students.Add(3, "Alice");
           // students.Add(1, "David");
           // students.Add(2, "Sophia");

           // // Display all key-value pairs
           // Console.WriteLine("Student List (Sorted by Key):");
           // foreach (KeyValuePair<int, string> kvp in students)
           // {
           //     Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
           // }

           // // Access by key
           // Console.WriteLine($"\nStudent with ID 2: {students[2]}");

           // // Remove an item
           // students.Remove(3);

           // Console.WriteLine("\nAfter removing ID 3:");
           // foreach (var kvp in students)
           // {
           //     Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
           // }

           // // Check if key exists
           // if (students.ContainsKey(1))
           //     Console.WriteLine("\nKey 1 exists!");

           // //simple use of IEnumerable and IEnumerator with yield return
           // CountdownYieldMultiple countdown = new CountdownYieldMultiple();
           // foreach (int number in countdown)
           // {
           //     Console.WriteLine(number);
           // }

           // LinkedList<string> linkedList = new LinkedList<string>();
           // linkedList.AddLast("First");
           // linkedList.AddLast("Second");
           // linkedList.AddLast("Third");
           // // Iterate through the linked list
           //linkedList.Remove("Second");
            //using Yield
            // Display powers of 2 up to the exponent of 8
            foreach (int item in Power(2, 8))
            {
                Console.WriteLine(item);
            }

            //List<Book> bookList = new List<Book>();
            //for (int i = 0;i<100;i++)
            //{
            //    Book book=BookFactory.CreateBook($"Book Title {i+1}", $"Author {i+1}",1990);
            //    bookList.Add( book);
            //}

        }
        // Iterator method using yield
        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }


      

    }
}
