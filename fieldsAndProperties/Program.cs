using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fieldsAndProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Animal dog= new Animal("Fido");
            //Animal cat =new Animal("Garfild");
            //Console.WriteLine($"Number of animal instance are : {Animal.animalCount}");


            ////using accessors

            //Animal animal = new Animal();
            //animal.Name ="Buddy";
            //Console.WriteLine($"Animal name is: {animal.Name} with Accessors");

            //Backin fields examples


            //Create a new Person object using the constructor
            Person person1 = new Person("John", "Doe", "123-45-6789");

            // Set SSN using the property (invokes the setter)
            person1.SSN = "987-65-4321";   // passes validation

            // Example of invalid SSN input (triggers validation)
            person1.SSN = "";   // "Input is not accepted."

            Console.WriteLine("Person object created successfully!");


            //PersonWithBackFields example

            PersonWithBackFields person2 = new PersonWithBackFields("Jane", "Smith", "111-22-3333", new DateTime(1990, 5, 15));
            Console.WriteLine($"Name: {person2.Name}, Last Name: {person2.LastName}, DOB: {person2.DOB.ToShortDateString()}");
            person2.LastName = "Johnson"; // Valid update
            Console.WriteLine($"Updated Last Name: {person2.LastName}");
            person2.LastName = ""; // Invalid update, triggers validation
            Console.WriteLine($"After invalid update, Last Name: {person2.LastName}");

            Console.WriteLine(person2.Name);


            //Expressoion Bodied Members

            SaleItem item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{ item.Name}: sells for{ item.Price:C2}"); ;

        }
    }


     
}
