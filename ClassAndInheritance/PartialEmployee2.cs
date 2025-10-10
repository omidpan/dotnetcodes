using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public partial class PartialEmployee
    {
        public PartialEmployee(int Id, string firstName, string lastName)
        {
            this.EmpID=Id;
            this.FirstName = firstName;
            this.LastName = lastName;

            //You can use partial method here since it is a private one 
             GenerateEmployeeId();
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("{0} {1} { 2}", this.EmpID, this.FirstName, this.LastName);
        }

    }
}
