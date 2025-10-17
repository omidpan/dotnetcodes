using method_extention_assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_extention_assembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);
            MyHelperClass myClass = new MyHelperClass("Hello From MyHellperClass and it's internal method");
            Console.WriteLine(myClass.WordCount());

        }
    }
}
