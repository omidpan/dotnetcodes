using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 In C#, strings are immutable.

Every time you modify a string (e.g., using + concatenation), a new string object is created
in memory.

This is fine for small operations, but if you’re building or modifying text repeatedly
(e.g., loops, large files), it becomes slow and memory-wasteful.
 
 */
namespace stringbuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            var start1 = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                result += i.ToString() + " ";  // Each loop creates a new string!
            }
            var end1 = DateTime.Now;
            Console.WriteLine("String time: " + (end1 - start1).TotalMilliseconds);
            Console.WriteLine(result);
            /******************** 
             StringBuilder (in System.Text) is a mutable string class.
             It allows you to modify text in place (append, insert, remove, replace) 
            without creating a new string every time.Much faster for repeated modifications.
             **********************************/


            StringBuilder sb = new StringBuilder();
            sb.Append("Hello"); // Append text.
            sb.Append(" World");
            sb.AppendLine("!");//Adds text and a newline.
            sb.Insert(6, "C# ");//Insert text at a specific position.
            sb.Replace("World", "Universe");
            sb.Remove(6, 6);  // Remove 6 chars from index 6(remove " Univer")

            Console.WriteLine(sb.ToString()); // Output: C# Universe!

            sb.Clear(); // Clear all content.
            Console.WriteLine("After Clear: '" + sb.ToString() + "'");
            /*
             * Let's compare the time taken by StringBuilder vs string concatenation in a loop.
             */
            var start2 = DateTime.Now;
            for (int i = 0; i < 10000; i++)
                sb.Append(i);
            var end2 = DateTime.Now;
            Console.WriteLine("StringBuilder time: " + (end2 - start2).TotalMilliseconds);
            Console.WriteLine(result.ToString());
        }
    }
}
