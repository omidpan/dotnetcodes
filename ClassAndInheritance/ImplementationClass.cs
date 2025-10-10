using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{

    internal class ImplementationClass : ISampleInterface
    {
        public void FirstMethod()
        {
            Console.WriteLine("Inside FirstMethod");

        }

        public void SecondMethod()
        {
            Console.WriteLine("Inside SecondMethod");

        }
    }
}
