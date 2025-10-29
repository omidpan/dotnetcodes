using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_and_reflections
{
    public interface Animal
    {

        void MakeSound();     
    }

    // Derived class
    public  class Dog : Animal
    {
        // Overriding the base class method
        public virtual void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        // Overriding the base class method
        public void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

}
