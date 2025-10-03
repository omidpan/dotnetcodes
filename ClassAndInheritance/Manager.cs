using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Manager:Employee
    {
        public string Department { get; set; }
                                                                             //This calls the Employee constructor
        public Manager(int id, string name, double salary, string department): base(id, name, salary) 
           
        {
            Department = department;
        }

        // Extra method for Manager
        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} (Manager of {Department}) approved the budget.");
        }
    }
}
