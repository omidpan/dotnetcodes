using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflectionwithcsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(printSomething(3.4m));   // decimal → currency
            Console.WriteLine(printSomething(3.4f));   // float → numeric
            Console.WriteLine(printSomething(100));    // int → no match

            // methods in reflection
     
            Book myBook = new Book("Reflection in C#", "Omid Panahi");

        // Get Type information
        Type typeInfoReflection = myBook.GetType();

        Console.WriteLine("=== CLASS INFORMATION ===");
        Console.WriteLine($"Class Name: {typeInfoReflection.Name}");
        Console.WriteLine($"Namespace: {typeInfoReflection.Namespace}");

            //how to get all the property names of the class(get class members

            Console.WriteLine("++++Look at all the  properties+++");
            foreach (PropertyInfo prop in typeInfoReflection.GetProperties())
            {
                Console.WriteLine($"{prop.Name}");
            }
            // Display methods
            Console.WriteLine("\n=== METHODS ===");
            foreach (MethodInfo method in typeInfoReflection.GetMethods())
            {
                Console.WriteLine($"{method.ReturnType.Name} {method.Name}()");
            }


            //Using IComparable ******************************
            //int a = 10;
            //int b = 5;

            //Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            //SwapIfGreater(ref a, ref b);
            //Console.WriteLine($"After Swap:  a = {a}, b = {b}");

            //// Works for strings too
            //string s1 = "Zebra";
            //string s2 = "Apple";

            //Console.WriteLine($"\nBefore Swap: s1 = {s1}, s2 = {s2}");
            //SwapIfGreater(ref s1, ref s2);
            //Console.WriteLine($"After Swap:  s1 = {s1}, s2 = {s2}");
        }

        public static string printSomething<T>(T val1)
        {
            if (val1.GetType() == typeof(decimal))
            {
                // Format as currency (e.g., $3.40)
                return string.Format("{0:C}", val1);
            }

            if (val1.GetType() == typeof(float))
            {
                // Format with 2 decimal places (e.g., 3.4 → 3.40)
                return string.Format("{0:0.##}", val1);
            }

            return string.Empty;
        }

        // Generic method that swaps two values if the first is greater than the second
        //static void SwapIfGreater<T>(ref T lhs, ref T rhs) where T : IComparable<T>
        //{
        //    T temp;
        //    if (lhs.CompareTo(rhs) > 0)
        //    {
        //        temp = lhs;
        //        lhs = rhs;
        //        rhs = temp;
        //    }
        //}
    }
    class CompareGenericClass<T>
    {
        public bool Compare(T x, T y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }
    }

    class Book
    {
        public string ISBN { get; set; }
        public int Edition { get; set; }
        public string Name { get; set; }

        public Book(string isbn, int edition, string name)
        {
            ISBN = isbn;
            Edition = edition;
            Name = name;
        }

    }
