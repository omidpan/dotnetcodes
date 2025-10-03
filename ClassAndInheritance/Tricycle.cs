using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public class Tricycle
    {
        // protected method:
        protected void Pedal() { }  //visible to same class or derived class

        // private field:           //visible to class
        private int wheels = 3;

        // protected internal property. Internal -> visible to same assembly
        protected internal int Wheels
        {
            get { return wheels; }
        }

    }
}
