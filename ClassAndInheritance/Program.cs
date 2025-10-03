using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee(101, "Alice", 50000);
            emp.DisplayInfo();

            // Create a Manager object (inherits from Employee)
            Manager mgr = new Manager(201, "Bob", 80000, "IT");
            mgr.DisplayInfo();
            mgr.ApproveBudget();



            //Abstract class and method example
            //BaseClass baseClass = BaseClass(); // This line will  cause a compile-time
                                               // error because we cannot instantiate an abstract class
            DerivedClass derived = new DerivedClass();
            derived.AbstractMethod(); // Call the implemented abstract method
            Console.WriteLine($"_x: {derived.GetX()}, _y: {derived.GetY()}");


            //Override abstract method
            var sq = new Square();
            Console.WriteLine($"Side of the square = {sq.Side}");
        }
    }
}
