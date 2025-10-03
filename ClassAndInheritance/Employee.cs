using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Employee
    {
        // Fields / Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        // Constructor
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"[Employee] ID: {Id}, Name: {Name}, Salary: {Salary:C}");
        }
    }
}
