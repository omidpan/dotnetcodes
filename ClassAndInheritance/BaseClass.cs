using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal abstract class BaseClass
    {
        protected int _x=100;
        protected int _y=200;

        // Abstract method (must be implemented in derived classes)
        public abstract void AbstractMethod();// no body just a signature of the method
    }
}
