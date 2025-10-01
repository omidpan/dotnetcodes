using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsAndProperties
{
    public class Animal
    {
        public string Name { get; set; } // field with get and set accessors
        internal static int animalCount = 0; // static field

        public Animal()
        {
            animalCount++;
        }
        public Animal(string name)
        {
            this.Name = name;
            animalCount++;
        }
    }
}
